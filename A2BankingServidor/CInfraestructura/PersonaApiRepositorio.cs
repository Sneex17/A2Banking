using CEntidades;
using Newtonsoft.Json;

namespace CInfraestructura
{
    public class PersonaApiRepositorio : IPersonaRepositorio
    {
        private readonly HttpClient _httpClient;
        public PersonaApiRepositorio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Persona>> ObtenerLista()
        {
            var resultado = await _httpClient.GetAsync("https://thesimpsonsapi.com/api/characters");
            resultado.EnsureSuccessStatusCode();
            var json = await resultado.Content.ReadAsStringAsync();
            var primeraPagina = JsonConvert.DeserializeObject<PersonaResponse>(json);

            var tarea = new List<Task<List<Persona>>>();
            for (int i = 2; i <= primeraPagina.pages; i++)
            {
                var pagina = i;
                tarea.Add(Task.Run(async () => 
                {
                    var r = await _httpClient.GetAsync($"https://thesimpsonsapi.com/api/characters?page={pagina}");
                    r.EnsureSuccessStatusCode();
                    var personaJson = await r.Content.ReadAsStringAsync();
                     
                    return JsonConvert.DeserializeObject<PersonaResponse>(personaJson).results;
                }));
            }

            var resultados = await Task.WhenAll(tarea);
            var listaCompleta = new List<Persona>(primeraPagina.results);

            foreach (var lista in resultados)
            {
                listaCompleta.AddRange(lista);
            }

            return listaCompleta;
        }
    }
}
