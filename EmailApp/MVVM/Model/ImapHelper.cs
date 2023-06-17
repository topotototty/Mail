using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmailApp.MVVM.Model
{
    static class ImapHelper
    {
        static ImapClient client = new ImapClient();
        static string _password;
        static string _email;

        static ImapHelper()
        {
            client.Connect("imap.gmail.com", 993, true);
        }

        public static void InitializeImap(string email, string password)
        {
            _email = email;
            _password = password;
            client.Authenticate(email, password);

        }

        public static IList<IMailFolder> GetFolders()
        {
            try
            {
                return client.GetFolders(new FolderNamespace('.', ""));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ObservableCollection<Email> GetEmails(string folderName)
        {
            ObservableCollection<Email> list = new ObservableCollection<Email>();
            var folder =  client.GetFolder(folderName);

            folder.Open(FolderAccess.ReadOnly);   

            int i = 0;
            foreach(var email in folder.Reverse())
            {
                list.Add(new Email(email.MessageId, email.Subject, email.From.ToString(), email.Date.ToString(), email.HtmlBody, email.TextBody));
                i++;
                if (i == 20) break;
            }

            return list;    
        }

        public static string ReadEmail(Email email)
        {
            if (email.htmlBody == null)
            {
                return email.textBody;
            }
            else
            {
                return email.htmlBody;
            }
        }

        public static void SendEmail(string text, string subject, string To)
        {

            // Создаем тело письма в формате текста
            var body = new TextPart("plain")
            {
                Text = text
            };

            // Создаем письмо
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_email, _password));
            message.To.Add(new MailboxAddress(To, To));
            message.Subject = subject;
            message.Body = body;

            // Отправляем письмо
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate(_email, _password);
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
            }
        }

        public static void LogOut()
        {
            client.Disconnect(true);
        }
    }
}