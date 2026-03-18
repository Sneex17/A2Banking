using CEntidades;

namespace CInfraestructura
{
    public class PersonaResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
        public int pages { get; set; }
        public List<Persona> results { get; set; }
    }
}
