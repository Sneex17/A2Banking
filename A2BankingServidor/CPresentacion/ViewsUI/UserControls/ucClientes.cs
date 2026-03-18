using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CNegocio;
using CPresentacion.Plantillas;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucClientes : ucPlantilla
    {
        public ucClientes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            viewDatos.DataSource = GetPersonasServicio.ListaTitulares();
        }

        private void LimpiarTextbox()
        {
            textbIdTitular.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbEdad.Text = string.Empty;
            texbSexo.Text = string.Empty;
            textbOcupacion.Text = string.Empty;
        }
        private void BuBuscarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                fmPersonas personas = new fmPersonas();

                personas.SeleccionarPersona += (persona) =>
                {
                    textbIdTitular.Text = persona.id.ToString();
                    textbNombre.Text = persona.name.ToString();
                    textbEdad.Text = persona.age.ToString();
                    texbSexo.Text = persona.gender.ToString();
                    textbOcupacion.Text = persona.occupation.ToString();
                };
                personas.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var titular = new Titular()
                {
                    TitularId = Convert.ToInt32(textbIdTitular.Text),
                    Nombre = textbNombre.Text,
                    Edad = Convert.ToInt32(textbEdad.Text),
                    Sexo = Convert.ToChar(texbSexo.Text),
                    Ocupacion = textbOcupacion.Text
                };

                var mensaje = MessageBox.Show("Desea registar a esta persona como cliente al sistema?", "Registro de clientes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    GetPersonasServicio.NuevoTitular(titular);

                    MessageBox.Show("Cliente registrado con exito", "Registro de clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                    LimpiarTextbox();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
