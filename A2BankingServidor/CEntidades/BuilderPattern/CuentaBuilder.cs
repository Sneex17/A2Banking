using CEntidades.StatePattern;

namespace CEntidades.BuilderPattern
{
    public class CuentaBuilder : ICuentaBuilder
    {
        private readonly Cuenta _cuenta = new Cuenta();
        public ICuentaBuilder conCuentaId(int cuentaId)
        {
            _cuenta.CuentaId = cuentaId;
            return this;
        }
        public ICuentaBuilder conBanco(Banco banco)
        {
            _cuenta.Banco = banco;
            return this;
        }
        public ICuentaBuilder conTitular(Titular titular)
        {
            _cuenta.Titular = titular;
            return this;
        }
        public ICuentaBuilder conNumeroCuenta(int numeroCuenta)
        {
            _cuenta.NumeroCuenta = numeroCuenta;
            return this;
        }
        public ICuentaBuilder conBalance(decimal balance)
        {
            _cuenta.Balance = balance;
            return this;
        }
        public ICuentaBuilder conFechaCreacion(DateTime fechaCreacion)
        {
            _cuenta.FechaCreacion = fechaCreacion;
            return this;
        }
        public ICuentaBuilder conEstado(CuentaEstado estado)
        {
            _cuenta.Estado = estado;
            return this;
        }
        public ICuentaBuilder conCodigoPin(int codigoPin)
        {
            _cuenta.CodigoPin = codigoPin;
            return this;
        }
        public ICuentaBuilder conCodigoHuella(byte[] codigoHuella)
        {
            _cuenta.CodigoHuella = codigoHuella;
            return this;
        }
        public Cuenta Builder()
        {
            return _cuenta;
        }
    }
}
