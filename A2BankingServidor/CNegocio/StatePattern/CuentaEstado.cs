using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.StatePattern
{
    public class CuentaEstado
    {
        private ICuentaEstados cuentaEstado;
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
