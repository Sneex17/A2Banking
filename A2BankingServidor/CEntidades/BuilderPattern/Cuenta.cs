using CEntidades.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.BuilderPattern
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public Banco Banco { get; set; }
        public Titular Titular { get; set; }
        public int NumeroCuenta { get; set; }
        public decimal Balance { get; set; }
        public DateTime FechaCreacion { get; set; }
        public CuentaEstado Estado { get; set; }
        public int CodigoPin { get; set; }
        public string CodigoHuella { get; set; }
    }
}
