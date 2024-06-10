using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace HamburgerAppMVC.Areas.Identity.Data
{
    public class MailSenderConfirm : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();

                var sender = "sepetsepethamburger@gmail.com";

                mailMessage.From = new MailAddress(sender);//Kimden 
                mailMessage.To.Add(email);//Kime
                mailMessage.Subject = subject;
                mailMessage.Body = htmlMessage;

                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;

                smtpClient.Credentials = new NetworkCredential(sender, "rmfyqrblxuxvmkzt");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtpClient.Send(mailMessage);

                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }
    }
}
