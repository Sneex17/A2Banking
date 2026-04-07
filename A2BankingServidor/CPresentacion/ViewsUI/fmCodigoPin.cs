using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CPresentacion.ViewsUI
{
    /// <summary>
    /// Formulario modal para la captura y confirmación del código PIN de una cuenta bancaria.
    /// Valida que ambos campos coincidan y cumplan la longitud mínima requerida,
    /// y expone el resultado a través de la propiedad estática <see cref="CodigoPIN"/>.
    /// </summary>
    public partial class fmCodigoPin : Form
    {
        /// <summary>
        /// Obtiene el código PIN capturado y confirmado por el usuario.
        /// Su valor es asignado únicamente desde dentro de la clase, al confirmar
        /// correctamente las validaciones en <see cref="BuGuardar_Click"/>.
        /// </summary>
        /// <value>
        ///   Cadena con el PIN ingresado, o <c>null</c> si el formulario no ha sido confirmado aún.
        /// </value>
        public static string CodigoPIN {  get; private set; }
        /// <summary>
        /// Inicializa el formulario <see cref="fmCodigoPin"/> y sus componentes visuales.
        /// </summary>
        public fmCodigoPin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuVerPin</c>.
        /// Alterna la visibilidad del texto en los campos <c>textbPin</c> y <c>textbPinConfirmacion</c>,
        /// cambiando el ícono entre <see cref="IconChar.Eye"/> (oculto) y <see cref="IconChar.EyeSlash"/> (visible).
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuVerPin_Click(object sender, EventArgs e)
        {
            if (BuVerPin.IconChar == IconChar.Eye)
            {
                textbPin.UseSystemPasswordChar = false;
                textbPinConfirmacion.UseSystemPasswordChar = false;
                BuVerPin.IconChar = IconChar.EyeSlash;
            }
            else
            {
                textbPin.UseSystemPasswordChar = true;
                textbPinConfirmacion.UseSystemPasswordChar = true;
                BuVerPin.IconChar = IconChar.Eye;
            }
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuGuardar</c>.
        /// Ejecuta las validaciones del PIN en orden y, si todas pasan,
        /// asigna el valor a <see cref="CodigoPIN"/> y cierra el formulario.
        /// </summary>
        /// <remarks>
        /// Las validaciones aplicadas son, en orden:
        /// <list type="number">
        ///   <item><description>El campo PIN no debe estar vacío.</description></item>
        ///   <item><description>El campo de confirmación no debe estar vacío.</description></item>
        ///   <item><description>Ambos campos deben coincidir exactamente.</description></item>
        ///   <item><description>El PIN debe tener al menos 4 dígitos.</description></item>
        /// </list>
        /// Ante cualquier incumplimiento se invoca <see cref="Excepciones"/> para mostrar el mensaje de error.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textbPin.Text))
            {
                Excepciones("Debe ingresar un código PIN");
            }
            else if (string.IsNullOrWhiteSpace(textbPinConfirmacion.Text))
            {
                Excepciones("Debe confirmar su código PIN");
            }
            else if (textbPin.Text != textbPinConfirmacion.Text)
            {
                Excepciones("El código PIN no coincide");
            }
            else if (textbPin.Text.Length < 3)
            {
                Excepciones("El código PIN debe tener al menos 4 digitos");
            }
            else
            {
                CodigoPIN = textbPin.Text;
                this.Close();
            }
        }
        /// <summary>
        /// Muestra un mensaje de error en la etiqueta <c>lbMensaje</c> del formulario,
        /// haciéndola visible y coloreándola en rojo (<see cref="Color.IndianRed"/>).
        /// </summary>
        /// <param name="mensaje">
        ///   Texto descriptivo del error de validación que se mostrará al usuario.
        /// </param>
        private void Excepciones(string mensaje)
        {
            lbMensaje.Visible = true;
            lbMensaje.ForeColor = Color.IndianRed;
            lbMensaje.Text = mensaje;
        }
    }
}
