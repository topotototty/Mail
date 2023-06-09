using EmailApp.MVVM.Model;
using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmailApp.MVVM.ViewModel.Helpers
{
    static class ImapHelper
    {
        static ImapClient client = new ImapClient();

        static ImapHelper()
        {
            client.Connect("imap.gmail.com", 993, true);
        }

        public static void InitializeImap(string email, string password)
        {
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
    }
}