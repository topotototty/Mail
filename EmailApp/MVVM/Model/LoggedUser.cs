using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp.MVVM.Model
{
    internal class LoggedUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int SmtpPort { get; set; }

        public int ImapPort { get; set; }
    }
}
