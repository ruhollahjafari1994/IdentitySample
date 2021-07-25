using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace IdentitySample.Repositories
{
    public class MessageSender : IMessageSender
    {
        public Task SendEmailAsync(string toEmail, string subject, string message, bool isMessageHtml = false)
        {
             using (var client = new SmtpClient())
            {

                var credentials = new NetworkCredential()
                {
                    UserName = "", // without @gmail.com
                    Password = "nv,hcifhca,"
                };

                client.Credentials = credentials;
                client.Host = "";
                client.Port = 587;
                client.EnableSsl = true;

                using var emailMessage = new MailMessage()
                {
                    To = { new MailAddress(toEmail) },
                    From = new MailAddress(""), // with @gmail.com
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = isMessageHtml
                };
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Send(emailMessage);
            }

            return Task.CompletedTask;
        }
    }
}
