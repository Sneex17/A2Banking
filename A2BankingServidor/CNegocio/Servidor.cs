using CDatos.Controllers;
using CEntidades.BuilderPattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio
{
    public class Servidor
    {
        TcpListener Servicio;

        public async void IniciarServidor()
        {
            try
            {
                Servicio = new TcpListener(IPAddress.Any, 1617);
                Servicio.Start();

                while (true)
                {
                    TcpClient cliente = await Servicio.AcceptTcpClientAsync();
                    _ = Task.Run(() => ControlServidor(cliente));
                }
            }
            catch (Exception)
            {

            }
        }

        private async Task ControlServidor(TcpClient client)
        {
            using (client)
            using (NetworkStream network = client.GetStream())
            {
                try
                {
                    // ===== LEER LONGITUD =====
                    byte[] lengthBuffer = new byte[4];
                    await network.ReadAsync(lengthBuffer);

                    int length = BitConverter.ToInt32(lengthBuffer);

                    // ===== LEER JSON =====
                    byte[] dataBuffer = new byte[length];
                    int totalRead = 0;

                    while (totalRead < length)
                    {
                        int read = await network.ReadAsync(
                            dataBuffer,
                            totalRead,
                            length - totalRead);

                        totalRead += read;
                    }

                    string mensaje =
                        Encoding.UTF8.GetString(dataBuffer);

                    var loginCuenta =
                        JsonConvert.DeserializeObject<Cuenta>(mensaje);

                    var respuesta =
                        CuentaController.LoginCajero(loginCuenta);

                    // ===== RESPUESTA =====
                    string json =
                        JsonConvert.SerializeObject(respuesta);

                    byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
                    byte[] longitud = BitConverter.GetBytes(jsonBytes.Length);

                    await network.WriteAsync(longitud);
                    await network.WriteAsync(jsonBytes);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
