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
    /// <summary>
    /// Control de usuario para la gestión de usuarios del sistema bancario.
    /// Permite registrar nuevos usuarios, actualizar sus datos y asignarles roles
    /// mediante <see cref="LogicaNegocio"/>.
    /// Hereda de <see cref="ucPlantilla"/> como plantilla base de presentación.
    /// </summary>
    public partial class ucUsuarios : ucPlantilla
    {
        /// /// <summary>
        /// Inicializa el control <see cref="ucUsuarios"/>, carga el combo de roles
        /// y la lista de usuarios registrados en el sistema.
        /// </summary>
        public ucUsuarios()
        {
            InitializeComponent();
            CargarComponentes();
            CargarDatos();
        }
        /// <summary>
        /// Configura el <c>ComboBox</c> de roles cargando la lista de roles disponibles
        /// desde <see cref="LogicaNegocio.ListaRoles"/>, estableciendo
        /// <c>RolId</c> como valor y <c>Nombre</c> como texto visible.
        /// </summary>
        private void CargarComponentes()
        {
            comboRoles.DataSource = LogicaNegocio.ListaRoles();
            comboRoles.ValueMember = "RolId";
            comboRoles.DisplayMember = "Nombre";
        }
        /// <summary>
        /// Carga la lista de usuarios registrados mediante <see cref="LogicaNegocio.ListaUsuarios"/>
        /// y la asigna como fuente de datos al <c>DataGridView</c> (viewDatos).
        /// También suscribe el evento de doble clic para seleccionar registros.
        /// </summary>
        private void CargarDatos()
        {
            viewDatos.DataSource = LogicaNegocio.ListaUsuarios();
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }
        /// <summary>
        /// Limpia el contenido de todos los campos de texto del formulario,
        /// dejándolos en su estado inicial (cadena vacía).
        /// </summary>
        private void LimpiarTexbox()
        {
            textbIdUsuario.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbUsuario.Text = string.Empty;
            textbPassword.Text = string.Empty;
        }
        /// <summary>
        /// Ajusta el color y el texto del botón Guardar según si se está registrando
        /// un nuevo usuario (ID vacío) o actualizando uno existente.
        /// </summary>
        /// <param name="id">
        ///   Identificador del usuario. Si es nulo o vacío, se configura el modo <c>Registrar</c>
        ///   (botón verde); de lo contrario, se configura el modo <c>Actualizar</c> (botón azul).
        /// </param>
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
        /// <summary>
        /// Maneja el evento de doble clic sobre una celda del <c>DataGridView</c>.
        /// Carga los datos del usuario de la fila seleccionada en los campos del formulario
        /// y actualiza el modo de operación a <c>Actualizar</c>.
        /// </summary>
        /// <param name="sender">El <see cref="DataGridView"/> que originó el evento.</param>
        /// <param name="e">Argumentos del evento que contienen el índice de fila y columna clicada.</param>
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
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuLimpiar</c>.
        /// Limpia todos los campos del formulario y restablece el modo de operación a <c>Registrar</c>.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexbox();
            CambioOperacion(textbIdUsuario.Text);
        }
        /// <summary>
        /// Ejecuta las validaciones de negocio sobre el objeto <see cref="Usuario"/> recibido
        /// mediante <see cref="ValidacionUsuario"/>.
        /// Si la validación falla, lanza una excepción con todos los mensajes de error concatenados.
        /// </summary>
        /// <param name="usuario">
        ///   Objeto <see cref="Usuario"/> cuyos datos serán validados antes de persistir.
        /// </param>
        /// <exception cref="ControlExcepciones">
        ///   Se lanza cuando uno o más campos del usuario no cumplen las reglas de validación.
        /// </exception>
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
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuGuardar</c>.
        /// Determina si la operación es un <b>registro</b> o una <b>actualización</b>
        /// según si el campo ID de usuario está vacío, y ejecuta la lógica correspondiente.
        /// </summary>
        /// <remarks>
        /// En modo <b>registro</b>: construye un <see cref="Usuario"/> sin ID, valida sus datos
        /// y lo persiste mediante <see cref="LogicaNegocio.AgregarUsuario"/>.<br/>
        /// En modo <b>actualización</b>: incluye el <c>UsuarioId</c> y persiste los cambios
        /// mediante <see cref="LogicaNegocio.ActualizarUsuario"/>.<br/>
        /// En ambos casos, tras confirmar la operación, recarga la tabla y limpia el formulario.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        /// <exception cref="ControlExcepciones">Error de validación de negocio sobre los datos del usuario.</exception>
        /// <exception cref="Exception">Cualquier otro error inesperado durante el registro o actualización.</exception>
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
