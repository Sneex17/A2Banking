using CDatos.Controllers;
using CEntidades;
using CInfraestructura;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;

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

        public static void NuevoTitular(Titular titular)
        {
            TitularController.InsertarCliente(titular);
        }

        public static List<Titular> ListaTitulares()
        {
            return TitularController.VerTitulares();
        }
    }
}
