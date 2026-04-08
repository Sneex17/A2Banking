using CPresentacion.ViewsUI;
using FontAwesome.Sharp;
using CEntidades;
using CNegocio;
namespace CPresentacion
{
    /// <summary>
    /// Formulario de inicio de sesión del sistema bancario.
    /// Gestiona la autenticación del usuario mediante credenciales (nombre de usuario y contraseña),
    /// y arranca el servidor de comunicaciones al cargar el formulario.
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Inicializa el formulario <see cref="Login"/>, configura los componentes visuales
        /// y suscribe el evento <c>Load</c> para iniciar el servidor al mostrar el formulario.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            CargarComponenes();
            Load += (s, e) => ServerRun();
        }
        /// <summary>
        /// Inicia el servidor de comunicaciones de forma asíncrona al cargar el formulario.
        /// Crea una instancia de <see cref="Servidor"/> y llama a <see cref="Servidor.IniciarServidor"/>.
        /// </summary>
        /// <remarks>
        /// El método es <c>async void</c> ya que se invoca desde el evento <c>Load</c>.
        /// Las excepciones no controladas dentro de este método no serán propagadas al llamador.
        /// </remarks>
        private async void ServerRun()
        {
            Servidor servidor = new Servidor();
            servidor.IniciarServidor();
        }
        /// <summary>
        /// Configura los componentes visuales del formulario en su estado inicial.
        /// Activa el modo de contraseña oculta en el campo <c>textbPassword</c>.
        /// </summary>
        private void CargarComponenes()
        {
            textbPassword.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuVerPassword</c>.
        /// Alterna la visibilidad del texto en el campo de contraseña y cambia el ícono
        /// entre <see cref="IconChar.Eye"/> (oculta) y <see cref="IconChar.EyeSlash"/> (visible).
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuVerPassword_Click(object sender, EventArgs e)
        {
            if (BuVerPassword.IconChar == IconChar.Eye)
            {
                textbPassword.UseSystemPasswordChar = false;
                BuVerPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                textbPassword.UseSystemPasswordChar = true;
                BuVerPassword.IconChar = IconChar.Eye;
            }
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuAcceder</c>.
        /// Construye un objeto <see cref="Usuario"/> con las credenciales ingresadas
        /// y verifica su existencia mediante <see cref="LogicaNegocio.UsuarioExiste"/>.
        /// Si las credenciales son válidas, abre el <see cref="MenuPrincipal"/> y oculta el login;
        /// de lo contrario, muestra un mensaje de error.
        /// </summary>
        /// <remarks>
        /// El valor retornado por <see cref="LogicaNegocio.UsuarioExiste"/> corresponde al
        /// identificador del usuario autenticado, el cual se pasa al <see cref="MenuPrincipal"/>
        /// para personalizar la sesión activa. Un resultado igual o menor a cero indica
        /// que las credenciales son incorrectas.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuAcceder_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                NombreUsuario =  textbUsuario.Text,
                Contrasena = textbPassword.Text
            };

            var resultado = LogicaNegocio.UsuarioExiste(usuario);
            if (resultado != null)
            {
                Logger.Instance.Log($"Usuario {usuario.NombreUsuario} inició sesión en el sistema");
                MenuPrincipal menu = new MenuPrincipal(resultado);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
