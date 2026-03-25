using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Plantillas;
using CEntidades.BuilderPattern;
using CEntidades.StatePattern;
using CEntidades;
using CNegocio;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucCuentas : ucPlantilla
    {
        public ucCuentas()
        {
            InitializeComponent();
        }

        private void BuCapturarHuella_Click(object sender, EventArgs e)
        {
            fmCapturarHuella capturarHuella = new fmCapturarHuella();
            capturarHuella.ShowDialog();

            if (!string.IsNullOrEmpty(capturarHuella.TemplateBase64))
                textbHuella.Text = capturarHuella.TemplateBase64;
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            var titular = new Titular()
            {
                TitularId = 1,
                Nombre = "Homer Simpson",
                Sexo = 'M',
                Edad = 39
            };

            var banco = new Banco()
            {
                BancoId = 1,
                Nombre = "A2 Banking"
            };

            var huella = Convert.FromBase64String(textbHuella.Text);

            var estado = new CuentaEstado();
            ICuentaBuilder cuentaBuilder = new CuentaBuilder();
            Cuenta cuenta = cuentaBuilder
                .conTitular(titular)
                .conBanco(banco)
                .conBalance(5000)
                .conNumeroCuenta(100000001)
                .conFechaCreacion(DateTime.Today)
                .conEstado(estado)
                .conCodigoPin(Convert.ToInt32(textbCodigoPin.Text))
                .conCodigoHuella(Convert.FromBase64String(textbHuella.Text))
                .Builder();
            textbCodigoPin.Text = "0x" + BitConverter.ToString(huella).Replace("-", "");
            //LogicaNegocio.CrearCuentas(cuenta);
        }
    }
}
