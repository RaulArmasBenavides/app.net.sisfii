using CapaPresentacion.Mail;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Constantes
{
    public class MimeKitMailTool : IMailService 
    {

        private string _cuerpoCorreo = string.Empty;
        //private SmtpClient cliente;
        //private static IConfiguration Configuration { get; set; }
        //private MailMessage email;
        public MimeKitMailTool()
        {

        }
 
        public void Send()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("SISTEMA CERSEU", "imanol123valera@gmail.co"));
            message.To.Add(new MailboxAddress("Ing. Wilder Ponce", "Testing.."));
            message.Subject = "Notificación de registro de evento";


            message.Body = new TextPart("plain")
            {
                Text = @"Se le comunica que ha sido registrada una nueva actividad en el sistema de eventos del CERSEU"
                      + "\n" + _cuerpoCorreo
            };



            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication

                client.Authenticate("imanol123valera@gmail.com", "@valera123");
                client.Send(message);
                client.Disconnect(true);
            }
        }


    

     


    }
}
