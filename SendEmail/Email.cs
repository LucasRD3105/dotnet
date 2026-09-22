using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace SendEmail
{
    public class Email
    {
        public string Porvedor { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public Email(string provedor, string username, string password)
        {
            Provedor = provedor ?? throw new ArgumentNullException(nameof(provedor));
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Passowrd = password ?? throw new ArgumentNullException(nameof(password));
        }

        public void SendEmail(List<string> emaislTo, string subject, string body, List<string> attatchments)
        {
            var message = PreaparateMessage(emaislTo, subject, body, attatchments);

            SendEmailBySmtp(message);
        }

        private MailMessage PreaparateMessage(List<string> emailsTo, string subject, string body, List<string> attatchments)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(Username);

            foreach (var email in emailsTo)
            {
                if (ValidateEmail(email))
                {
                    mail.To.Add(email);
                }

            }

            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            foreach (var file in attatchments)
            {
                var data = new Attachment(file, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(file);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

                mail.Attachments.Add(data);
            }

            return mail;
        }

        private bool ValidateEmail(string email)
        {
            Regex expression = new Regex(@"\w+@[a-zA-Z_]+?\. [a-zA-Z]{2,3}");
            if (expression.IsMatch(email))
                return true;
            return false;
        }

        private void SendEmailBySmtp(MailMessage message)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = Porvedor;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 50000;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(Username, Password);
            smtpClient.Send(message);
            smtpClient.Dispose();
        }
    }
}