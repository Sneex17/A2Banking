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

        public void SelecionarOperacion(Cuenta cuenta, int ClienteId, string Nombre)
        {
            if(_operacio == null)
            {
                throw new ArgumentNullException();
            }
            _operacio.Operacion(cuenta, ClienteId,Nombre);
        }
    }

}
