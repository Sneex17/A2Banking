using CDatos.Controllers;
using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class DepositStrategy : IOperacionStrategy
    {
        public void Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            CuentaController.DepositarBalance(cuenta, ClienteId, Nombre);
        }
    }

}
