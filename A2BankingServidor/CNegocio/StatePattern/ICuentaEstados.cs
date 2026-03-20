namespace CNegocio.StatePattern
{
    public interface ICuentaEstados
    {
        void Activa(CuentaEstado estado);
        void Inactiva(CuentaEstado estado);
        void Cancelada(CuentaEstado estado);
        public int EstadoID { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
    }

}
