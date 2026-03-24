using CEntidades;
using System.Media;

namespace CPresentacion
{
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }
        private void SonidoBotones()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Sonido.GetSonido();
            player.Play();
        }

        private void pbButton1_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 1;
        }

        private void pbButton2_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 2;
        }

        private void pbButton3_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 3;
        }

        private void pbButton4_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 4;
        }

        private void pbButton5_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 5;
        }

        private void pbButton6_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 6;
        }

        private void pbButton7_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 7;
        }

        private void pbButton8_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 8;
        }

        private void pbButton9_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 9;
        }

        private void pbButton0_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text += 0;
        }

        private void pbButtonCancel_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textb.Text = string.Empty;
        }

        private void pbButtonClear_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            if(!string.IsNullOrWhiteSpace(textb.Text))
            {
                textb.Text = textb.Text.Remove(textb.TextLength - 1);
            }    
        }

        private void pbButtonEnter_Click(object sender, EventArgs e)
        {
            SonidoBotones();
        }
    }
}
