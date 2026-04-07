using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace CInfraestructura.EnviarGmail
{
    public abstract class ServicioGmail
    {
        private static string _servidor { get; } = "smtp.gmail.com";
        private static int _puerto { get; } = 587;
        private static string _user { get; } = "";
        private static string _pass { get; set; } = "pona jlno escw ilny";

        public static void EnviarCorreo(string correoCliente, string subject, string ruta)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Banco", _user));
            mensaje.To.Add(new MailboxAddress("Cliente", correoCliente));
            mensaje.Subject = subject;

            var cuerpoMensaje = new BodyBuilder();
            cuerpoMensaje.Attachments.Add(ruta);

            mensaje.Body = cuerpoMensaje.ToMessageBody();

            var clienteSmtp = new SmtpClient();
            clienteSmtp.CheckCertificateRevocation = false;
            clienteSmtp.Connect(_servidor, _puerto, SecureSocketOptions.StartTls);
            clienteSmtp.Authenticate(_user, _pass);
            clienteSmtp.Send(mensaje);
            clienteSmtp.Disconnect(true);
;       }


        public static string VerificarCorreo(string correoCliente)
        {
            string codigo = "";
            var letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var random = new Random();
            int num1 = random.Next(0, 27);
            int num2 = random.Next(0, 27);
            codigo = $"{letras[num1]}{num2}{letras[num2]}{num1}";

            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Banco", _user));
            mensaje.To.Add(new MailboxAddress("Cliente", correoCliente));
            mensaje.Subject = "Verificación de Correo";

            var cuerpoMensaje = new BodyBuilder();
            cuerpoMensaje.TextBody = $"Código de verificación: {codigo}";
            mensaje.Body = cuerpoMensaje.ToMessageBody();

            var clienteSmtp = new SmtpClient();
            clienteSmtp.CheckCertificateRevocation = false;
            clienteSmtp.Connect(_servidor, _puerto, SecureSocketOptions.StartTls);
            clienteSmtp.Authenticate(_user, _pass);
            clienteSmtp.Send(mensaje);
            clienteSmtp.Disconnect(true);
            
            return codigo;
        }

        public static bool CorreoValido(params string[] codigo)
        {
            return (codigo[0] == codigo[1]) ? true : false;
        }
    }
}
