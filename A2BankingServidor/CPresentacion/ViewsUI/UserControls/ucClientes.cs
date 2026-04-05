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
    /// Control de usuario para la gestión y registro de clientes (titulares) del sistema bancario.
    /// Permite buscar personas desde un servicio externo, visualizar sus datos
    /// y registrarlas como titulares mediante <see cref="GetPersonasServicio"/>.
    /// Hereda de <see cref="ucPlantilla"/> como plantilla base de presentación.
    /// </summary>
    public partial class ucClientes : ucPlantilla
    {
        /// <summary>
        /// Inicializa el control <see cref="ucClientes"/> y carga la lista de titulares
        /// registrados en el sistema al iniciar el componente.
        /// </summary>
        public ucClientes()
        {
            InitializeComponent();
            CargarDatos();
        }
        /// <summary>
        /// Obtiene la lista de titulares registrados mediante <see cref="GetPersonasServicio.ListaTitulares"/>
        /// y la asigna como fuente de datos al <c>DataGridView</c> (viewDatos).
        /// </summary>
        private void CargarDatos()
        {
            viewDatos.DataSource = GetPersonasServicio.ListaTitulares();
        }
        /// <summary>
        /// Limpia el contenido de todos los campos de texto del formulario,
        /// dejándolos en su estado inicial (cadena vacía).
        /// </summary>
        private void LimpiarTextbox()
        {
            textbIdTitular.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbEdad.Text = string.Empty;
            texbSexo.Text = string.Empty;
            textbOcupacion.Text = string.Empty;
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuBuscarPersonas</c>.
        /// Abre el diálogo <see cref="fmPersonas"/> para buscar y seleccionar una persona
        /// desde el servicio externo, cargando sus datos en los campos del formulario.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        /// <exception cref="Exception">
        ///   Captura cualquier error inesperado al abrir o interactuar con el diálogo de búsqueda.
        /// </exception>
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
                Logger.Instance.Log($"Error en la operación: {error.Message}");
            }
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuGuardar</c>.
        /// Construye un objeto <see cref="Titular"/> con los datos del formulario y,
        /// previa confirmación del usuario, lo registra en el sistema como nuevo cliente
        /// mediante <see cref="GetPersonasServicio.NuevoTitular"/>.
        /// </summary>
        /// <remarks>
        /// Tras un registro exitoso, recarga la tabla de clientes y limpia los campos del formulario.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        /// <exception cref="ControlExcepciones">
        ///   Se lanza cuando los datos del titular no superan las validaciones de negocio.
        /// </exception>
        /// <exception cref="Exception">
        ///   Captura cualquier otro error inesperado durante el proceso de registro.
        /// </exception>
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

                    Logger.Instance.Log($"Se registró un nuevo cliente al sistema: {titular.Nombre}");

                    CargarDatos();
                    LimpiarTextbox();
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
