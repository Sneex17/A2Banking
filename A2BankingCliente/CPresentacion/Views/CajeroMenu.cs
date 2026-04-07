using CEntidades;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Media;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CNegocio;

namespace CPresentacion.Views
{
    public partial class CajeroMenu : Form
    {
        TcpClient cliente;
        int controlValor = 0;
        Cuenta cuenta = new Cuenta();
        bool Comprobacion = false;
        bool Verificacion = false;
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
            if (!string.IsNullOrWhiteSpace(textbCantidad.Text))
            {
                textbCantidad.Text = string.Empty;
            }
            if (!string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
            {
                textbCuentaDestino.Text = string.Empty;
            }
            controlValor = numero;
            lbTextOpcion.Visible = true;
            lbTextOpcion.Text = mensaje;
            textbCuentaDestino.Enabled = true;
            lbTitularDestino.Visible = false;

            if (textbCuentaDestino.Visible == true && lbTextDestino.Visible == true)
            {
                textbCuentaDestino.Visible = false;
                lbTextDestino.Visible = false;
                lbtextbClienteNombre.Visible = false;
            }
        }

        private void AddNumero(int numero)
        {
            if (textbCantidad.ContainsFocus)
            {
                textbCantidad.Text += numero;
            }
            if (textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.ContainsFocus)
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
            if (textbCantidad.ContainsFocus)
            {
                textbCantidad.Text = string.Empty;
            }
            if (textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.ContainsFocus)
                {
                    textbCuentaDestino.Text = string.Empty;
                }
            }
        }

        private void pbButtonClear_Click(object sender, EventArgs e)
        {
            SonidoBotones();

            if (textbCantidad.ContainsFocus)
            {
                if (!string.IsNullOrWhiteSpace(textbCantidad.Text))
                {
                    textbCantidad.Text = textbCantidad.Text.Remove(textbCantidad.Text.Length - 1);
                }
            }
            if (textbCuentaDestino.Visible == true)
            {
                if (textbCuentaDestino.ContainsFocus)
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
            try
            {
                SonidoBotones();
                if (controlValor == 0)
                {
                    throw new ControlExcepcion("Debe selecionar una operación del menu");
                }

                using (var fmVerificarHuella =  new fmVerificarHuella(this.cuenta.CodigoHuella))
                {
                    fmVerificarHuella.ShowDialog();
                    Verificacion = fmVerificarHuella.Resultado;
                }
                
                
                if(Verificacion)
                {
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
                                    var mensaje = MessageBox.Show($"Desea dépositar: {textbCantidad.Text}?", "Déposito de dinero",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (mensaje == DialogResult.Yes)
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
                                if (Convert.ToDecimal(textbCantidad.Text) > cuenta.Balance)
                                {
                                    lbTextDestino.Visible = true;
                                    lbTextDestino.Text = "Balance insuficiente".ToString();
                                }
                                else
                                {
                                    var mensaje = MessageBox.Show($"Desea dépositar: {textbCantidad.Text}?", "Déposito de dinero",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (mensaje == DialogResult.Yes)
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
                                if (string.IsNullOrWhiteSpace(textbCantidad.Text))
                                {
                                    throw new ControlExcepcion("Debe ingresar un monto a transferir");
                                }
                                if (string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
                                {
                                    throw new ControlExcepcion("Debe ingresar una cuenta de destino");
                                }

                                var transferencia = new Transferencia()
                                {
                                    Monto = Convert.ToDecimal(textbCantidad.Text),
                                    CuentaOrigenId = this.cuenta.NumeroCuenta,
                                    CuentaDestinoId = Convert.ToInt32(textbCuentaDestino.Text),
                                    Concepto = "Transferencia bancaria",
                                    Fecha = DateTime.Now
                                };

                                var paquete = new Paquetes()
                                {
                                    Mensaje = "Transferencia",
                                    Transferir = transferencia
                                };

                                EnvioPaquetes(cliente, paquete);
                            }
                            break;
                    }
                }
                else
                {
                    throw new ControlExcepcion("Debe de verificar que es el propietario de la cuenta con su huella");
                }
                
            }
            catch (ControlExcepcion error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            pbBotonComprobar.Visible = false;
            lbComprobar.Visible = false;
        }

        private void pbBotonRetirar_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textbCantidad.Visible = true;
            textbCantidad.Enabled = true;
            ControlOpciones(2, "Cantidad a retirar");
            pbBotonComprobar.Visible = false;
            lbComprobar.Visible = false;
        }

        private void pbBotonAyuda_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            pbBotonComprobar.Visible = false;
            lbComprobar.Visible = false;
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
            pbBotonComprobar.Visible = false;
            lbComprobar.Visible = false;
        }

        private void pbBotonTransferir_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            textbCantidad.Visible = true;
            textbCantidad.Enabled = false;
            ControlOpciones(3, "Cantidad a transferir");
            lbTextDestino.Visible = true;
            textbCuentaDestino.Visible = true;
            pbBotonComprobar.Visible = true;
            lbComprobar.Visible = true;
        }

        private void pbBotonSalir_Click(object sender, EventArgs e)
        {
            SonidoBotones();
            CajeroInicio inicio = new CajeroInicio();
            inicio.Show();
            this.Hide();
        }

        private async void pbBotonComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                SonidoBotones();
                if (string.IsNullOrWhiteSpace(textbCuentaDestino.Text))
                {
                    throw new ControlExcepcion("Ingrese el numero de cuenta que desea transferir el dinero");
                }

                var cuenta = new Cuenta()
                {
                    NumeroCuenta = Convert.ToInt32(textbCuentaDestino.Text)
                };

                var paquete = new Paquetes()
                {
                    Mensaje = "Comprobar cuenta",
                    Datos = cuenta
                };


                cliente = new TcpClient();
                await cliente.ConnectAsync("127.0.0.1", 1617);

                NetworkStream network = cliente.GetStream();

                string jsonCuenta = JsonConvert.SerializeObject(paquete);
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
                    if(respuesta.Estado.IdEstado == 2)
                    {
                        throw new ControlExcepcion($"La cuenta {respuesta.NumeroCuenta} esta inactiva");
                    }
                    if (respuesta.Estado.IdEstado == 3)
                    {
                        throw new ControlExcepcion($"La cuenta {respuesta.NumeroCuenta} esta cancelada");
                    }
                    lbTitularDestino.Visible = true;
                    lbTitularDestino.Text = $"Titular: {respuesta.Titular.Nombre}";
                    textbCuentaDestino.Enabled = false;
                    textbCantidad.Enabled = true;
                    pbBotonComprobar.Visible = false;
                    lbComprobar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Credenciales incorrecta", "Cajero",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            catch (ControlExcepcion error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
