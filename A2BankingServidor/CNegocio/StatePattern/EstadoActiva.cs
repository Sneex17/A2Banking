namespace CNegocio.StatePattern
{
    public class EstadoActiva : ICuentaEstados
    {
        public int EstadoID => 1;
        public string Nombre => "Activa";
        public string Descripcion => "Cuenta activa, se puede usar con normalidad";

        public void Activa(CuentaEstado estado) { }
        public void Cancelada(CuentaEstado estado)
        {
            estado.CambiarEstado(new EstadoCancelada());
        }
        public void Inactiva(CuentaEstado estado)
        {
            estado.CambiarEstado(new EstadoInactiva());
        }
    }

}
