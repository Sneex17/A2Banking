using CEntidades;
using CEntidades.BuilderPattern;
using CInfraestructura.RecibosServicios;
using CNegocio;
using CPresentacion.Plantillas;
using Microsoft.VisualBasic.ApplicationServices;
using QuestPDF;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucTransferencias : ucPlantilla
    {
        public ucTransferencias()
        {
            InitializeComponent();
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            viewDatos.DataSource = LogicaNegocio.ListaTransferencias();
        }

        private void LimpiarTextBox()
        {
            textbCuentaOrigen.Text =  string.Empty;
            textbRemitente.Text = string.Empty;
            textbCuentaBalance.Text = string.Empty;
            textbCantidad.Text = string.Empty;
            textbCuentaDesino.Text = string.Empty;
            textbDestinatario.Text = string.Empty;
            rTextbConcepto.Text = string.Empty;
        }
        private void pgBuBuscarOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                textbRemitente.Text = ValidarCuentas(textbCuentaOrigen.Text);
                if (!string.IsNullOrWhiteSpace(textbRemitente.Text))
                {
                    textbCuentaOrigen.Enabled = false;
                    var balance = LogicaNegocio.ListaCuentas().Select($"NumeroCuenta = {textbCuentaOrigen.Text}");
                    textbCuentaBalance.Text = balance[0]["Balance"].ToString();
                    textbCuentaDesino.Focus();
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pgBuBuscarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbCuentaDesino.Text == textbCuentaOrigen.Text)
                {
                    throw new ControlExcepciones("La cuenta del destinatario no puede ser la misma que la cuenta del remitente");
                }

                textbDestinatario.Text = ValidarCuentas(textbCuentaDesino.Text);
                if (!string.IsNullOrWhiteSpace(textbDestinatario.Text))
                {
                    textbCuentaDesino.Enabled = false;
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCuentas(string cuenta)
        {
            if (string.IsNullOrWhiteSpace(cuenta))
            {
                throw new ControlExcepciones("Debe ingresar el número de cuenta");
            }

            var listaCuenats = LogicaNegocio.ListaCuentas().Select($"NumeroCuenta = {cuenta}");

            if (listaCuenats.Length <= 0)
            {
                throw new ControlExcepciones("Cuenta no encontrada.\nCompruebe el número de la cuenta");
            }

            return listaCuenats[0]["Nombre"].ToString();
        }

        private  void BuTransferir_Click(object sender, EventArgs e)
        {
            Settings.License = LicenseType.Community;
            /*try
            {
                if (string.IsNullOrWhiteSpace(textbCantidad.Text))
                {
                    throw new ControlExcepciones("Debe de ingresar un monto a transferir");
                }

                if (string.IsNullOrWhiteSpace(rTextbConcepto.Text))
                {
                    rTextbConcepto.Text = "Sin concepto";
                }

                var transferencia = new Transferencia()
                {
                    CuentaOrigenId = Convert.ToInt32(textbCuentaOrigen.Text),
                    CuentaDestinoId = Convert.ToInt32(textbCuentaDesino.Text),
                    Concepto = rTextbConcepto.Text,
                    Fecha = DateTime.Now,
                    Monto = Convert.ToDecimal(textbCantidad.Text)
                };

                var validar = new ValidacionTransferencia();
                var resultado = validar.Validate(transferencia);

                if (!resultado.IsValid)
                {
                    string mensaje = string.Join("\n", resultado.Errors.Select(M => M.ErrorMessage));
                    throw new ControlExcepciones(mensaje);
                }

                var acction = MessageBox.Show($"Desea procesar esta transferencia?", 
                    "Tranferencia bancaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(acction == DialogResult.Yes)
                {
                    LogicaNegocio.ProcesarTransferencia(transferencia);
                    MessageBox.Show($"Transferencia completada con exito!", "Tranferencia bancaria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTextBox();

                    CargarDatos();
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


            var bank = new Bank();
            var data = LogicaNegocio.DataReciboTransferencia();
            var recido = new ReciboTransferencia(bank, data);
            recido.GeneratePdf(bank.RutaTrasnferencias);

            /*var bank = new Bank();
            var data = LogicaNegocio.DataReciboDeposito();
            var recido = new ReciboDeposito(bank, data);
            recido.GeneratePdf(bank.RutaDeposito);*/

            /*var bank = new Bank();
            var data = LogicaNegocio.DataReciboRetiro();
            var recido = new ReciboRetiro(bank, data);
            recido.GeneratePdf(bank.RutaRetiro);*/



        }
    }
}
