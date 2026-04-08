using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class GetBalanceStrategy : IOperacionStrategy
    {
        public int Operacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            throw new NotImplementedException();
        }
    }

}
