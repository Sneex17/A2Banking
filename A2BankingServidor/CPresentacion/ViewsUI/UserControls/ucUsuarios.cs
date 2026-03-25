using CEntidades;
using CNegocio;
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
    public partial class ucUsuarios : ucPlantilla
    {
        public ucUsuarios()
        {
            InitializeComponent();
            CargarComponentes();
            CargarDatos();
        }

        private void CargarComponentes()
        {
            comboRoles.DataSource = LogicaNegocio.ListaRoles();
            comboRoles.ValueMember = "RolId";
            comboRoles.DisplayMember = "Nombre";
        }

        private void CargarDatos()
        {
            viewDatos.DataSource = LogicaNegocio.ListaUsuarios();
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }

        private void LimpiarTexbox()
        {
            textbIdUsuario.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbUsuario.Text = string.Empty;
            textbPassword.Text = string.Empty;
        }

        private void CambioOperacion(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                BuGuardar.ColorBackground = Color.Green;
                BuGuardar.TextButton = "Registrar";
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
                textbIdUsuario.Text = viewDatos.Rows[e.RowIndex].Cells["UsuarioId"].Value.ToString();
                comboRoles.Text = viewDatos.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                textbNombre.Text = viewDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textbUsuario.Text = viewDatos.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                textbPassword.Text = viewDatos.Rows[e.RowIndex].Cells["Contrasena"].Value.ToString();
            }
            CambioOperacion(textbIdUsuario.Text);
        }

        private void BuLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexbox();
            CambioOperacion(textbIdUsuario.Text);
        }

        private void validaciones(Usuario usuario)
        {
            var validacion = new ValidacionUsuario();
            var resultado = validacion.Validate(usuario);

            if(!resultado.IsValid)
            {
                string mensaje = string.Join("\n", resultado.Errors.Select(M => M.ErrorMessage));
                throw new ControlExcepciones(mensaje);
            }
        }
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdUsuario.Text))
                {
                    var usuarios = new Usuario()
                    {
                        Nombre = textbNombre.Text,
                        RolId = Convert.ToInt32(comboRoles.SelectedValue.ToString()),
                        NombreUsuario = textbUsuario.Text,
                        Contrasena = textbPassword.Text,
                    };

                    validaciones(usuarios);

                    var mensaje = MessageBox.Show($"Desea agregar este usuario?", "Registro de usuario",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(mensaje == DialogResult.Yes)
                    {
                        LogicaNegocio.AgregarUsuario(usuarios);
                        MessageBox.Show($"Usuario registrado con exito!", "Registro de usuario completo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarTexbox();
                        CambioOperacion(textbIdUsuario.Text);
                    }
                }
                else
                {
                    var usuarios = new Usuario()
                    {
                        UsuarioId = Convert.ToInt32(textbIdUsuario.Text),
                        Nombre = textbNombre.Text,
                        RolId = Convert.ToInt32(comboRoles.SelectedValue.ToString()),
                        NombreUsuario = textbUsuario.Text,
                        Contrasena = textbPassword.Text,
                    };

                    validaciones(usuarios);

                    var mensaje = MessageBox.Show($"Desea actualizar los datos de este usuario?", "Actualización de usuario",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        LogicaNegocio.ActualizarUsuario(usuarios);
                        MessageBox.Show($"Datos del usuarios actualizados con exito!", "Actualización de usuario completo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarTexbox();
                        CambioOperacion(textbIdUsuario.Text);
                    }
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Errror en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}","Errror en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
