using CEntidades;
using CInfraestructura;

namespace CNegocio
{
    public class PersonaServices
    {
        private readonly IPersonaRepositorio _repository;
        public PersonaServices(IPersonaRepositorio repositorio)
        {
            _repository = repositorio;
        }
        public async Task<List<Persona>> ObtenerPersona()
        {
            return await _repository.ObtenerLista();
        }
    }
}
