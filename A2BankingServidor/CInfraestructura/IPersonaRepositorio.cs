using CEntidades;

namespace CInfraestructura
{
    public interface IPersonaRepositorio
    {
        Task<List<Persona>> ObtenerLista();
    }
}
