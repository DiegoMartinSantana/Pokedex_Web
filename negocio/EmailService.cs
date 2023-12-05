using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmailService
    {
        private SmtpClient server;
        private MailMessage correo;


        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("aspprueba500@gmail.com", "jcgfphrzwljlsqow");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";

        }

        public void armarCorreo( string emaildestino,string asunto,string mensaje)
        {
            correo = new MailMessage();
            correo.From = new MailAddress("noresponder@pruebaasp.com");
            correo.To.Add(emaildestino);
            correo.Subject = asunto;
            correo.IsBodyHtml = true;
            correo.Body = mensaje;

        }
        public void enviarCorreo()
        {
            try
            {
                server.Send(correo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
