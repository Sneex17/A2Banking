using CEntidades.BuilderPattern;

namespace CNegocio.StrategyPattern
{
    public class TransaccionContext
    {
        private IOperacionStrategy _operacio;

        public TransaccionContext(IOperacionStrategy operacion)
        {
            _operacio = operacion;
        }

        public int SelecionarOperacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            if(_operacio == null)
            {
                throw new ArgumentNullException();
            }
            return _operacio.Operacion(cuenta, ClienteId, Nombre);
        }
    }

}
