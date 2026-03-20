

using CEntidades.StatePattern;

namespace CEntidades.BuilderPattern
{
    public interface ICuentaBuilder
    {
        ICuentaBuilder conCuentaId(int cuentaId);
        ICuentaBuilder conBanco(Banco banco);
        ICuentaBuilder conTitular(Titular titular);
        ICuentaBuilder conNumeroCuenta(int numeroCuenta);
        ICuentaBuilder conBalance(decimal balance);
        ICuentaBuilder conFechaCreacion(DateTime fechaCreacion);
        ICuentaBuilder conEstado(CuentaEstado estado);
        ICuentaBuilder conCodigoPin(int codigoPin);
        ICuentaBuilder conCodigoHuella(string codigoHuella);
        Cuenta Builder();
    }
}
