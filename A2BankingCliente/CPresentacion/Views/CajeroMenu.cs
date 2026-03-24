using CEntidades;
using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CPresentacion.Views
{
    public partial class CajeroMenu : Form
    {
        int controlValor = 0;
        public CajeroMenu()
        {
            InitializeComponent();
        }
        private void SonidoBotones()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Sonido.GetSonido();
            player.Play();
        }
        private void ControlOpciones(int numero, string mensaje)
        {
            if(!string.IsNullOrWhiteSpace(textbCantidad.Text))
            {
                textbCantidad.Text = string.Empty;
            }
            if (!string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
            {
                textbCuentaDestino.Text = string.Empty;
            }
            controlValor = numero;
            lbTextOpcion.Text = mensaje;

            if(textbCuentaDestino.Visible == true && lbTextDestino.Visible == true)
            {
                textbCuentaDestino.Visible = false;
                lbTextDestino.Visible = false;
            }
        }

        private void AddNumero(int numero)
        {
            if (textbCantidad.Focused)
            {
                textbCantidad.Text += numero;
            }
            if(textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.Focused)
                {
                    textbCuentaDestino.Text += numero;
                }
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
            if (textbCantidad.Focused)
            {
                textbCantidad.Text = string.Empty;
            }
            if (textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.Focused)
                {
                    textbCuentaDestino.Text = string.Empty;
                }
            }
        }

        private void pbButtonClear_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            if (textbCantidad.Focused)
            {
                if (!string.IsNullOrWhiteSpace(textbCantidad.Text))
                {
                    textbCantidad.Text = textbCantidad.Text.Remove(textbCantidad.TextLength - 1);
                }
            }
            if(textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.Focused)
                {
                    if (!string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
                    {
                        textbCuentaDestino.Text = textbCuentaDestino.Text.Remove(textbCuentaDestino.TextLength - 1);
                    }
                }
            }
        }

        private void pbButtonEnter_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            switch (controlValor)
            {
                case 1:
                    {

                    }
                    break;

                case 2:
                    {

                    }
                    break;

                case 3:
                    {

                    }
                    break;

            }
        }

        private void pbBotonDepositar_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            ControlOpciones(1, "Cantidad a dépositar");
        }

        private void pbBotonRetirar_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            ControlOpciones(2, "Cantidad a retirar");
        }

        private void pbBotonAyuda_Click(object sender, EventArgs e)
        {
            SonidoBotones();

        }

        private void pbBotonSaldo_Click(object sender, EventArgs e)
        {
            SonidoBotones();
        }

        private void pbBotonTransferir_Click(object sender, EventArgs e)
        {
            SonidoBotones();       
            ControlOpciones(3, "Cantidad a transferir");
            lbTextDestino.Visible = true;
            textbCuentaDestino.Visible = true;
        }

        private void pbBotonSalir_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            CajeroInicio inicio = new CajeroInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
