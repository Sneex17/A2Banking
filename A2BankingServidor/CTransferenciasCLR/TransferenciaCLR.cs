using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace CTransferenciasCLR
{
    public class TransferenciaCLR
    {
        [SqlFunction]
        public static decimal AplicarComision(decimal monto, decimal comision)
        {
            var cantidaFinal = monto + (monto * comision);
            return cantidaFinal;
        }
    }
}
