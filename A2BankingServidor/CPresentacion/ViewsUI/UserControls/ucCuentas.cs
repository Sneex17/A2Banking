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
            CargarDatos();
        }

        private void CargarDatos()
        {
            viewDatos.DataSource = LogicaNegocio.ListaCuentas();
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }
        private void LimpiarTexbox()
        {
            textbIdCuenta.Text = string.Empty;
            textbNumeroCuenta.Text = string.Empty;
            textbIdTitular.Text = string.Empty;
            textbNombreTitular.Text = string.Empty;
            textbEstadoCuenta.Text = string.Empty;
            textbCodigoPin.Text = string.Empty;
            textbHuella.Text = string.Empty;
        }
        private void validaciones(Cuenta cuenta)
        {
            var validacion = new ValidacionCuenta();
            var resultado = validacion.Validate(cuenta);

            if (!resultado.IsValid)
            {
                string mensaje = string.Join("\n", resultado.Errors.Select(M => M.ErrorMessage));
                throw new ControlExcepciones(mensaje);
            }
        }
        private void CambioOperacion(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                BuGuardar.ColorBackground = Color.Green;
                BuGuardar.TextButton = "Crear";
            }
            else
            {
                BuGuardar.ColorBackground = Color.DodgerBlue;
                BuGuardar.TextButton = "Actualizar";
            }
        }
        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textbIdCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["CuentaId"].Value.ToString();
                textbNumeroCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["NumeroCuenta"].Value.ToString();
                textbIdTitular.Text = viewDatos.Rows[e.RowIndex].Cells["TitularId"].Value.ToString();
                textbNombreTitular.Text = viewDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textbEstadoCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                textbCodigoPin.Text = viewDatos.Rows[e.RowIndex].Cells["CodigoPin"].Value.ToString();
                textbHuella.Text = viewDatos.Rows[e.RowIndex].Cells["CodigoHuella"].Value.ToString();
            }
            CambioOperacion(textbIdCuenta.Text);
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
                TitularId = Convert.ToInt32(textbIdTitular.Text),
                Nombre = textbNombreTitular.Text,
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
                .conNumeroCuenta(Convert.ToInt32(textbNumeroCuenta.Text))
                .conFechaCreacion(DateTime.Today)
                .conEstado(estado)
                .conCodigoPin(Convert.ToInt32(textbCodigoPin.Text))
                .conCodigoHuella(Convert.FromBase64String(textbHuella.Text))
                .Builder();
            //textbCodigoPin.Text = "0x" + BitConverter.ToString(huella).Replace("-", "");
            //LogicaNegocio.CrearCuentas(cuenta);
        }

        private void BuBuscarPersonas_Click(object sender, EventArgs e)
        {
            fmTitulares titulares = new fmTitulares();
            titulares.SeleccionarTitular += (titular) =>
            {
                textbIdTitular.Text = titular.TitularId.ToString();
                textbNombreTitular.Text = titular.Nombre.ToString();
            };
            titulares.ShowDialog();

            var estado = new CuentaEstado();
            textbEstadoCuenta.Text = estado.cuentaEstado.Nombre;
            textbNumeroCuenta.Text = LogicaNegocio.GeneralNumeroCuenta();
        }

        private void BuLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexbox();
            CambioOperacion(textbIdCuenta.Text);
        }
    }
}
