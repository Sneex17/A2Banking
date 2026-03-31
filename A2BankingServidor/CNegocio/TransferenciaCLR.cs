using Microsoft.SqlServer.Server;

namespace CNegocio
{
    public partial class TransferenciaCLR
    {
        [SqlFunction]
        public static decimal AplicarComision(decimal monto, decimal comision)
        {
            var cantidaFinal = monto + (monto * comision);
            return cantidaFinal;
        }
    }
}
