using CDatos.Controllers;
using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class DepositStrategy : IOperacionStrategy
    {
        public int Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            return CuentaController.DepositarBalance(cuenta, ClienteId, Nombre);
        }
    }

}
