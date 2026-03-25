using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class GetBalanceStrategy : IOperacionStrategy
    {
        public void Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            throw new NotImplementedException();
        }
    }

}
