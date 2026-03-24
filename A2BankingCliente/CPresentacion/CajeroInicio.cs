using CEntidades;
using System.Media;
using CPresentacion.Views;

namespace CPresentacion
{
    public partial class CajeroInicio : Form
    {
        public CajeroInicio()
        {
            InitializeComponent();
        }
        private void SonidoBotones()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Sonido.GetSonido();
            player.Play();
        }
        private void AddNumero(int numero)
        {
            if (textbNCuenta.Focused)
            {
                textbNCuenta.Text += numero;
            }
            if (textbCodigoPin.Focused)
            {
                textbCodigoPin.Text += numero;
            }
        }

        private void pbButton1_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(1);
        }

        private void pbButton2_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(2);
        }

        private void pbButton3_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(3);
        }

        private void pbButton4_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(4);
        }

        private void pbButton5_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(5);
        }

        private void pbButton6_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(6);
        }

        private void pbButton7_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(7);
        }

        private void pbButton8_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(8);
        }

        private void pbButton9_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(9);
        }

        private void pbButton0_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            AddNumero(0);
        }

        private void pbButtonCancel_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            if (textbNCuenta.Focused)
            {
                textbNCuenta.Text = string.Empty;
            }
            if (textbCodigoPin.Focused)
            {
                textbCodigoPin.Text = string.Empty;
            }
        }

        private void pbButtonClear_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            if (textbNCuenta.Focused)
            {
                if (!string.IsNullOrWhiteSpace(textbNCuenta.Text))
                {
                    textbNCuenta.Text = textbNCuenta.Text.Remove(textbNCuenta.TextLength - 1);
                }
            }
            if (textbCodigoPin.Focused)
            {
                if (!string.IsNullOrWhiteSpace(textbCodigoPin.Text))
                {
                    textbCodigoPin.Text = textbCodigoPin.Text.Remove(textbCodigoPin.TextLength - 1);
                }
            }   
        }

        private void pbButtonEnter_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            CajeroMenu cajeroMenu = new CajeroMenu();
            cajeroMenu.Show();
            this.Hide();
        }
    }
}
