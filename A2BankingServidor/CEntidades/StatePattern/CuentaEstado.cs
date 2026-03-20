using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public class CuentaEstado
    {
        public ICuentaEstados cuentaEstado {  get; private set; }
        public CuentaEstado()
        {
            cuentaEstado = new EstadoActiva();
        }
        public void CambiarEstado(ICuentaEstados estado)
        {
            cuentaEstado = estado;
        }
        public void Activa() => cuentaEstado.Activa(this);
        public void Inactiva() => cuentaEstado.Inactiva(this);
        public void Cancelada() => cuentaEstado.Cancelada(this);
    }

}
