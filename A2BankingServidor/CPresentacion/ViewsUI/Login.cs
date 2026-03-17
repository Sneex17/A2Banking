using CPresentacion.ViewsUI;
using FontAwesome.Sharp;

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
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
