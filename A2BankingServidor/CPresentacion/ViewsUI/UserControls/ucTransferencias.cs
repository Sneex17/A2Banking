using CEntidades;
using CEntidades.BuilderPattern;
using CInfraestructura.EnviarGmail;
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
        int TitularIdO = 0;
        int TitularIdD = 0;
        public ucTransferencias()
        {
            InitializeComponent();
            CargarDatos();
            QuestPDF.Settings.License = LicenseType.Community;
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

                    var titular = LogicaNegocio.ListaCuentas().Select($"NumeroCuenta = {textbCuentaOrigen.Text}");
                    TitularIdO = Convert.ToInt32(titular[0]["TitularId"].ToString());
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
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

                    var titular = LogicaNegocio.ListaCuentas().Select($"NumeroCuenta = {textbCuentaDesino.Text}");
                    TitularIdD = Convert.ToInt32(titular[0]["TitularId"].ToString());
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
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
            try
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
                    var resultados = LogicaNegocio.ProcesarTransferencia(transferencia);

                    if (resultados > 0)
                    {
                        MessageBox.Show($"Transferencia completada con exito!", "Tranferencia bancaria",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.Instance.Log($"Se realizó una transferencia:\nCuenta: {transferencia.CuentaOrigenId}\nDestino: {transferencia.CuentaDestinoId}");
                        LimpiarTextBox();

                        CargarDatos();

                        string correoO = LogicaNegocio.ListaTitulares()
                                        .Where(L => L.TitularId == TitularIdO)
                                        .Select(M => M.Correo)
                                        .FirstOrDefault();

                        var bank = new Bank();
                        string ruta = bank.RutaTrasnferencias;
                        var data = LogicaNegocio.DataReciboTransferencia();
                        var recido = new ReciboTransferencia(bank, data);
                        recido.GeneratePdf(ruta);

                        ServicioGmail.EnviarCorreo(correoO, "Transferencia de dinero", ruta);

                        string correoD = LogicaNegocio.ListaTitulares()
                                        .Where(L => L.TitularId == TitularIdD)
                                        .Select(M => M.Correo)
                                        .FirstOrDefault();

                        string ruta2 = bank.RutaDeposito;
                        var data2 = LogicaNegocio.DataReciboDeposito();
                        var recido2 = new ReciboDeposito(bank, data2);
                        recido2.GeneratePdf(ruta2);

                        ServicioGmail.EnviarCorreo(correoD, "Déposito de dinero", ruta2);
                    }
                    else
                    {
                        throw new ControlExcepciones($"Ocurrió un error al procesar la transferencia");
                    }
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Error en la operación: {error.Message}");
            }
        }
    }
}
