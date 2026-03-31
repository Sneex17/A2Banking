using CEntidades;
using CPresentacion.Views;
using Newtonsoft.Json;
using System.Media;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class CajeroInicio : Form
    {
        TcpClient cliente;
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

        private async void pbButtonEnter_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            try
            {
                if(textbNCuenta.Text.Length != 9)
                {
                    
                }

                var cuenta = new Cuenta()
                {
                    NumeroCuenta = Convert.ToInt32(textbNCuenta.Text),
                    CodigoPin = Convert.ToInt32(textbCodigoPin.Text)
                };

                cliente = new TcpClient();
                await cliente.ConnectAsync("127.0.0.1", 1617);

                NetworkStream network = cliente.GetStream();

                string jsonCuenta = JsonConvert.SerializeObject(cuenta);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonCuenta);

                //  enviar longitud
                byte[] longitud = BitConverter.GetBytes(jsonBytes.Length);

                await network.WriteAsync(longitud);
                await network.WriteAsync(jsonBytes);

                // ===== RECIBIR RESPUESTA =====

                byte[] longitudBytes = new byte[4];
                await network.ReadAsync(longitudBytes);

                int totalBytes = BitConverter.ToInt32(longitudBytes);

                byte[] buffer = new byte[totalBytes];
                int totalLeido = 0;

                while (totalLeido < totalBytes)
                {
                    int leido = await network.ReadAsync(
                        buffer,
                        totalLeido,
                        totalBytes - totalLeido);

                    totalLeido += leido;
                }

                string respuestaJson =
                    Encoding.UTF8.GetString(buffer);

                var respuesta =
                    JsonConvert.DeserializeObject<Cuenta>(respuestaJson);

                if (respuesta != null)
                {
                    new CajeroMenu(respuesta).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales no incorrecta", "Cajero",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
