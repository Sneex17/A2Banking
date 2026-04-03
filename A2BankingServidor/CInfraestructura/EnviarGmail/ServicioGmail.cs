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
;        }
    }
}
