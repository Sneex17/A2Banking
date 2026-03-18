using CEntidades;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using CInfraestructura;

namespace CNegocio
{
    public class GetPersonasServicio
    {
        public static async Task<List<Persona>> GetPersonas()
        {
            IPersonaRepositorio personaRepositorio = new PersonaApiRepositorio(new HttpClient());
            var personas = new PersonaServices(personaRepositorio);
            return await personas.ObtenerPersona();
        }
    }
}
