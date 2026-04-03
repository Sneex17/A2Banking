using CEntidades;
using CEntidades.BuilderPattern;
using CInfraestructura.RecibosServicios;
using CNegocio;
using CNegocio.StrategyPattern;
using CPresentacion.Plantillas;
using QuestPDF.Fluent;
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
    public partial class ucRetiros : ucPlantilla
    {
        public ucRetiros()
        {
            InitializeComponent();
            CargarComponentes();
        }
        private void CargarComponentes()
        {
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }
        private void LimpiarTextbox()
        {
            textbIdTitular.Text = string.Empty;
            textbNombreTitular.Text = string.Empty;
            textbIdCuenta.Text = string.Empty;
            textbNumeroCuenta.Text = string.Empty;
            textbCantidad.Text = string.Empty;
        }

        private void BuBuscar_Click(object sender, EventArgs e)
        {
            fmTitulares titulares = new fmTitulares();
            titulares.SeleccionarTitular += (titular) =>
            {
                textbIdTitular.Text = titular.TitularId.ToString();
                textbNombreTitular.Text = titular.Nombre.ToString();
            };
            titulares.ShowDialog();

            CargarCuentas(textbIdTitular.Text);
        }

        private async void CargarCuentas(string titulaid)
        {
            if (!string.IsNullOrWhiteSpace(titulaid))
            {
                await Task.Delay(1500);
                var listaCuentaPorTirular = LogicaNegocio.ListaCuentas().Select($"TitularId = {titulaid}");
                if (listaCuentaPorTirular.Length > 0)
                {
                    viewDatos.DataSource = listaCuentaPorTirular.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show($"{textbNombreTitular.Text} no es titular de ninguna cuenta en este banco", "Cuantas de banco",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextbox();
                }
            }
        }
        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textbIdCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["CuentaId"].Value.ToString();
                textbNumeroCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["NumeroCuenta"].Value.ToString();
                textbBalanceActual.Text = viewDatos.Rows[e.RowIndex].Cells["Balance"].Value.ToString();
            }
        }

        private void BuAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDecimal(textbCantidad.Text) > Convert.ToDecimal(textbBalanceActual.Text))
                {
                    throw new ControlExcepciones($"La cantidad a retirar debe ser menor o igual al balance actual\nBalance actual: {textbBalanceActual.Text}");
                }

                if (Convert.ToDecimal(textbCantidad.Text) <= 0)
                {
                    throw new ControlExcepciones($"La cantidad a retirar debe ser mayor a cero");
                }

                var mensaje = MessageBox.Show($"Desea retirar {textbCantidad.Text} a la cuenta {textbNumeroCuenta.Text}?", "Retiro de dinero",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    var cuenta = new Cuenta()
                    {
                        CuentaId = Convert.ToInt32(textbIdCuenta.Text),
                        NumeroCuenta = Convert.ToInt32(textbNumeroCuenta.Text),
                        Titular = new Titular()
                        {
                            TitularId = Convert.ToInt32(textbIdTitular.Text),
                            Nombre = textbNombreTitular.Text
                        },
                        Balance = Convert.ToDecimal(textbCantidad.Text)
                    };

                    TransaccionContext transaccion = new TransaccionContext(new WithdrawStrategy());
                    transaccion.SelecionarOperacion(cuenta, Convert.ToInt32(textbIdTitular.Text), textbNombreTitular.Text);

                    MessageBox.Show("Retiro realizado con exito!", "Retiro completado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    viewDatos.DataSource = null;
                    LimpiarTextbox();

                    /*var bank = new Bank();
                    string ruta = bank.RutaRetiro;
                    var data = LogicaNegocio.DataReciboRetiro();
                    var recido = new ReciboRetiro(bank, data);
                    recido.GeneratePdf(ruta);*/
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
    }
}
