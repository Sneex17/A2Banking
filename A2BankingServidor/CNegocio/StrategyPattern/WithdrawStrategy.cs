using CDatos.Controllers;
using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class WithdrawStrategy : IOperacionStrategy
    {
        public void Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            CuentaController.RetirarBalance(cuenta, ClienteId, Nombre);
        }
    }

}
