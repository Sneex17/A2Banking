using CPresentacion.ViewsUI;
using FontAwesome.Sharp;
using CEntidades;
using CNegocio;
namespace CPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CargarComponenes();
        }

        private void CargarComponenes()
        {
            textbPassword.UseSystemPasswordChar = true;
        }

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

        private void BuAcceder_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                NombreUsuario =  textbUsuario.Text,
                Contrasena = textbPassword.Text
            };

            int resultado = LogicaNegocio.UsuarioExiste(usuario);
            if (resultado > 0)
            {
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
