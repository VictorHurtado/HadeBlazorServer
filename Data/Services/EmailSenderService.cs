using System.Threading.Tasks;
using System.Linq;
using MailKit.Net.Smtp;
using CititorServer.Data.Model;
using CititorServer.Data.Service;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using MimeKit;

namespace CititorServer.Data.Service
{
    public class EmailSenderService : IEmailSenderService
    {       
        private readonly SmtpSettings _smtpSettings;

        public EmailSenderService(IOptions<SmtpSettings> smtpSettings)
            {
                _smtpSettings = smtpSettings.Value;
            }
        public async Task SendEmailAsync(MailRequest request)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_smtpSettings.SenderName, _smtpSettings.SenderEmail));
                message.To.Add(new MailboxAddress("", request.Email));
                message.Subject = request.Subject;
                message.Body = new TextPart("html") { Text = request.Body };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_smtpSettings.Server);
                    await client.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            } catch (Exception ){

                
            }
        }
    }
}
