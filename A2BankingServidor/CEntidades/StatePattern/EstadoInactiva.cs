namespace CEntidades.StatePattern
{
    public class EstadoInactiva : ICuentaEstados
    {
        public int EstadoID => 2;
        public string Nombre => "Inactiva";
        public string Descripcion => "Cuenta inactiva, no se puede usar";

        public void Activa(CuentaEstado estado)
        {
            estado.CambiarEstado(new EstadoActiva());
        }
        public void Cancelada(CuentaEstado estado)
        {
            estado.CambiarEstado(new EstadoCancelada());
        }
        public void Inactiva(CuentaEstado estado) { }

    }

}
