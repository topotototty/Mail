using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp.MVVM.Model
{
    internal class Email
    {
        public string id { get; set; }
        public string subject { get; set; }
        public string from { get; set; }
        public string date { get; set; }

        public string htmlBody { get; set; }
        public string textBody { get; set; }

        public Email(string id, string subject, string from, string date, string htmlBody, string textBody) 
        {
            this.id = id;
            this.subject = subject;
            this.from = from;
            this.date = date;
            this.htmlBody = htmlBody;
            this.textBody = textBody;
        }
    }
}
