using CEntidades;
using CEntidades.BuilderPattern;
using CNegocio;
using CNegocio.StrategyPattern;
using CPresentacion.Plantillas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucDepositos : ucPlantilla
    {
        public ucDepositos()
        {
            InitializeComponent();
            CargarCuentas();
        }

        private void CargarCuentas()
        {
            viewDatos.DataSource = LogicaNegocio.ListaCuentas();
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }
        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                texbIdCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["CuentaId"].Value.ToString();
                textbNumeroCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["NumeroCuenta"].Value.ToString();
                textbTitular.Text = viewDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }

        private void LimpiarTextbox()
        {
            textbIdCliente.Text = string.Empty;
            textbNombreCliente.Text = string.Empty;
            texbIdCuenta.Text = string.Empty;
            textbNumeroCuenta.Text = string.Empty;
            textbTitular.Text = string.Empty;
            textbCantidad.Text = string.Empty;
        }
        private void BuBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                fmPersonas personas = new fmPersonas();

                personas.SeleccionarPersona += (persona) =>
                {
                    textbIdCliente.Text = persona.id.ToString();
                    textbNombreCliente.Text = persona.name.ToString();
                };
                personas.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(textbCantidad.Text) <= 0)
                {
                    throw new ControlExcepciones($"La cantidad a retirar debe ser mayor a cero");
                }

                var mensaje = MessageBox.Show($"Desea dépositar {textbCantidad.Text} a la cuenta {textbNumeroCuenta.Text}?", "Déposito de dinero",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(mensaje == DialogResult.Yes)
                {
                    var cuenta = new Cuenta()
                    {
                        CuentaId = Convert.ToInt32(texbIdCuenta.Text),
                        NumeroCuenta = Convert.ToInt32(textbNumeroCuenta.Text),
                        Titular = new Titular()
                        {
                            Nombre = textbTitular.Text
                        },
                        Balance = Convert.ToDecimal(textbCantidad.Text)
                    };

                    TransaccionContext transaccion = new TransaccionContext(new DepositStrategy());
                    transaccion.SelecionarOperacion(cuenta, Convert.ToInt32(textbIdCliente.Text), textbNombreCliente.Text);

                    MessageBox.Show("Déposito realizado con exito!", "Déposito completado", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    CargarCuentas();
                    LimpiarTextbox();
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

        private void BuLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextbox();
        }
    }
}
