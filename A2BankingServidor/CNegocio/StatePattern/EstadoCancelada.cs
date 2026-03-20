namespace CNegocio.StatePattern
{
    public class EstadoCancelada : ICuentaEstados
    {
        public int EstadoID => 3;
        public string Nombre => "Cancelada";
        public string Descripcion => "La cuenta a sigo cancelada permanentemente";

        public void Activa(CuentaEstado estado) { }
        public void Cancelada(CuentaEstado estado) { }
        public void Inactiva(CuentaEstado estado) { }
    }

}
