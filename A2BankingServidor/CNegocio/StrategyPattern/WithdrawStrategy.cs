using CDatos.Controllers;
using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class WithdrawStrategy : IOperacionStrategy
    {
        public int Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            return CuentaController.RetirarBalance(cuenta, ClienteId, Nombre);
        }
    }

}
