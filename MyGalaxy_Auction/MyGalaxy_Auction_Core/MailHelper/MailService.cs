using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace MyGalaxy_Auction_Core.MailHelper
{
    public class MailService : IMailService
    {
        public void SendEmail(string subject, string body, string email)
        {
            try
            {
                var emailToSend = new MimeMessage();
                emailToSend.From.Add(MailboxAddress.Parse("YourGalaxyAuction@gmail.com"));
                emailToSend.To.Add(MailboxAddress.Parse(email));
                emailToSend.Subject = subject;
                emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

                // Send email
                using var emailClient = new SmtpClient();
                emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("pelinsy66@gmail.com", "ihoxtbyqcotgfehe"); // Use an application-specific password if needed
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"E-posta gönderimi sırasında bir hata oluştu: {ex.Message}");
                throw new Exception("E-posta gönderiminde bir hata oluştu.", ex);
            }
        }
    }
}
