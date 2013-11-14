using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security.Authentication;

namespace ER4Aerea
{
    class Email
    {

        public void enviar(string email)
        {
            MailMessage mensagem = new MailMessage(
                "er4aerea@gmail.com",
                email,
                "Promoção",
                "vou levar... te levar daquiiiiiii, pra nuvi");
            SmtpClient envio = new SmtpClient("smtp.gmail.com");
            envio.Port = 25;
            envio.Timeout = 10;
            
            envio.Credentials = new NetworkCredential("er4aerea","peludinha");
            
            envio.EnableSsl = true;
            envio.Send(mensagem);
        }
    }
}
