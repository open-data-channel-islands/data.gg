using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DataGg.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _config;

        private bool _hasSection = false;

        private string _host;
        private string _from;
        private int _port;
        private bool _enableSsl;
        private string _username;
        private string _password;

        public EmailSender(IConfiguration config)
        {
            _config = config;

            if (_config.GetSection("EmailSender") != null)
            {
                _from = _config["EmailSender:From"];
                _host = _config["EmailSender:Host"];
                _port = _config.GetValue<int>("EmailSender:Port");
                _enableSsl = _config.GetValue<bool>("EmailSender:EnableSSL");
                _username = _config["EmailSender:UserName"];
                _password = _config["EmailSender:Password"];
                _hasSection = true;
            }
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            if (!_hasSection)
            {
                return;
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("data.gg", _from));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;
            message.Body = new TextPart("html") { Text = htmlMessage };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_host, _port, _enableSsl);
                await client.AuthenticateAsync(_username, _password);

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

            /*            var client = new SmtpClient(_host, _port)
                        {
                            Credentials = new NetworkCredential(_username, _password),
                            EnableSsl = _enableSsl
                        };

                        await client.SendMailAsync(
                            new MailMessage(_from, email, subject, htmlMessage) { IsBodyHtml = true }
                        );*/
        }
    }
}
