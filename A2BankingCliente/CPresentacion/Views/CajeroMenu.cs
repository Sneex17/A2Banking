using CEntidades;
using Newtonsoft.Json;
using System.Media;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CPresentacion.Views
{
    public partial class CajeroMenu : Form
    {
        TcpClient cliente;
        int controlValor = 0;
        Cuenta cuenta = new Cuenta();
        public CajeroMenu(Cuenta Cuenta)
        {
            InitializeComponent();
            cuenta = Cuenta;
            lbtextbClienteNombre
            .Text = $"{cuenta.Titular.Nombre}";
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
                    textbCantidad.Text = textbCantidad.Text.Remove(textbCantidad.Text.Length - 1);
                }
            }
            if(textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.Focused)
                {
                    if (!string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
                    {
                        textbCuentaDestino.Text = textbCuentaDestino.Text.Remove(textbCuentaDestino.Text.Length - 1);
                    }
                }
            }
        }

        private void pbButtonEnter_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            switch (controlValor)
            {
                //Depositar dinero
                case 1:
                    {
                        if (Convert.ToDecimal(textbCantidad.Text) < 1)
                        {
                            lbTextDestino.Visible = true;
                            lbTextDestino.Text = "Cantidad al dépositar invalidad".ToString();
                        }
                        else
                        {
                            var mensaje = MessageBox.Show($"Desea dépositar: {textbCantidad.Text}?","Déposito de dinero",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if(mensaje == DialogResult.Yes)
                            {
                                var Cuenta = new Cuenta()
                                {
                                    NumeroCuenta = cuenta.NumeroCuenta,
                                    Balance = Convert.ToDecimal(textbCantidad.Text),
                                    Titular = cuenta.Titular
                                };

                                var paquete = new Paquetes()
                                {
                                    Mensaje = "Deposito",
                                    Datos = Cuenta
                                };

                                EnvioPaquetes(cliente, paquete);
                            }
                        }
                    }
                    break;
                //Retirar dinero
                case 2:
                    {
                        if(Convert.ToDecimal(textbCantidad.Text) > cuenta.Balance)
                        {
                            lbTextDestino.Visible = true;
                            lbTextDestino.Text = "Balance insuficiente".ToString();
                        }
                        else
                        {
                            var mensaje = MessageBox.Show($"Desea dépositar: {textbCantidad.Text}?", "Déposito de dinero",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if(mensaje == DialogResult.Yes)
                            {
                                var Cuenta = new Cuenta()
                                {
                                    NumeroCuenta = cuenta.NumeroCuenta,
                                    Balance = Convert.ToDecimal(textbCantidad.Text),
                                    Titular = cuenta.Titular
                                };

                                var paquete = new Paquetes()
                                {
                                    Mensaje = "Retiro",
                                    Datos = Cuenta
                                };

                                EnvioPaquetes(cliente, paquete);
                            }
                        }
                    }
                    break;
                //Transferir dinero
                case 3:
                    {

                    }
                    break;
            }
        }
        private async void EnvioPaquetes(TcpClient cliente, Paquetes paguete)
        {
            cliente = new TcpClient();
            await cliente.ConnectAsync("127.0.0.1", 1617);

            NetworkStream network = cliente.GetStream();

            string jsonCuenta = JsonConvert.SerializeObject(paguete);
            byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonCuenta);

            //  enviar longitud
            byte[] longitud = BitConverter.GetBytes(jsonBytes.Length);

            await network.WriteAsync(longitud);
            await network.WriteAsync(jsonBytes);
        }

        private void pbBotonDepositar_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textbCantidad.Visible = true;
            textbCantidad.Enabled = true;
            ControlOpciones(1, "Cantidad a dépositar");
        }

        private void pbBotonRetirar_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textbCantidad.Visible = true;
            textbCantidad.Enabled = true;
            ControlOpciones(2, "Cantidad a retirar");
        }

        private void pbBotonAyuda_Click(object sender, EventArgs e)
        {
            SonidoBotones();

        }

        private void pbBotonSaldo_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            lbTextOpcion.Text = $"Balance disponible";
            textbCantidad.Visible = true;
            textbCantidad.Text = $"{cuenta.Balance}";
            textbCantidad.Enabled = false;
            lbTextDestino.Visible = false;
            textbCuentaDestino.Visible = false;
        }

        private void pbBotonTransferir_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textbCantidad.Visible = true;
            textbCantidad.Enabled = true;
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
