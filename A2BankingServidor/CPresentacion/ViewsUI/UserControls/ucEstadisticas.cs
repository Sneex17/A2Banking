using CNegocio;
using MimeKit.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucEstadisticas : UserControl
    {
        public ucEstadisticas()
        {
            InitializeComponent();
        }
        private void ucEstadisticas_Load(object sender, EventArgs e)
        {
            DatosDepositos();
            DatosRetiros();
            DatosTransferencias();
            DatosCuentas();
            DatosSistemaBanco();
        }
        private void DatosTransferencias()
        {
            var count = LogicaNegocio.ListaTransferencias().Count;
            var countToday = LogicaNegocio.ListaTransferencias().Count(L => L.Fecha.Date == DateTime.Today);

            LbCountTransferencias.Text = count.ToString();
            LbCountTransferenciasHoy.Text = $"+{countToday.ToString()}";
        }

        private void DatosDepositos()
        {
            var count = LogicaNegocio.ListaDeposito().Count;
            var countToday = LogicaNegocio.ListaDeposito().Count(L => L.Fecha.Date == DateTime.Today);

            LbCountDepositos.Text = count.ToString();
            LbCountDepositosHoy.Text = $"+{countToday.ToString()}";
        }

        private void DatosRetiros()
        {
            var count = LogicaNegocio.ListaRetiro().Count;
            var countToday = LogicaNegocio.ListaRetiro().Count(L => L.Fecha.Date == DateTime.Today);

            LbCountRetiros.Text = count.ToString();
            LbCountRetirosHoy.Text = $"+{countToday.ToString()}";
        }

        private void DatosCuentas()
        {
            var count = LogicaNegocio.CountCuentas().Count;
            var countToday = LogicaNegocio.CountCuentas().Count(L => L.FechaCreacion.Date == DateTime.Today);
            var countActivo = LogicaNegocio.CountCuentas().Count(L => L.Estado.cuentaEstado.EstadoID == 1);
            var countInactivo = LogicaNegocio.CountCuentas().Count(L => L.Estado.cuentaEstado.EstadoID == 2);
            var countCancelada = LogicaNegocio.CountCuentas().Count(L => L.Estado.cuentaEstado.EstadoID == 3);

            LbCountCuentas.Text = count.ToString();
            LbCountCuentasHoy.Text = $"+{countToday.ToString()}";
            LbCountCActivas.Text = countActivo.ToString();
            LbCountCInactivas.Text = countInactivo.ToString();
            LbCountCCanceladas.Text = countCancelada.ToString();
        }


        private void DatosSistemaBanco()
        {
            decimal balance = 0;
            var ganancia = LogicaNegocio.CountGanancias();
            var countRoles = LogicaNegocio.ListaRoles().Count;
            var coutUser = LogicaNegocio.ListaUsuarios().Rows.Count;

            foreach (var countBalance in LogicaNegocio.CountCuentas())
            {
                balance += countBalance.Balance;
            }

            LbCountRoles.Text = countRoles.ToString();
            LbCountUser.Text = coutUser.ToString();
            LbCountBalance.Text = $"${balance.ToString()}";
            LbCountGanancia.Text = $"+${ganancia.ToString()}";
            LbCountBalanceTotal.Text = $"${balance + ganancia}";
        }
    }
}
