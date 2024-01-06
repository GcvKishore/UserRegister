using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using UserRegister.Models;

namespace UserRegister.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IOptions<EmailSenderOptions> _emailSenderOptions;

        public EmailSender(IOptions<EmailSenderOptions> emailSenderOptions)
        {
            _emailSenderOptions = emailSenderOptions;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            EmailSenderOptions options = _emailSenderOptions.Value;

            SmtpClient client = new SmtpClient(options.SmtpServer)
            {
                Port = options.Port,
                Credentials = new NetworkCredential(options.Username, options.Password),
                EnableSsl = options.UseSSL,
                UseDefaultCredentials = false,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(options.Username),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(email);
            return client.SendMailAsync(mailMessage);
        }
    }

}
