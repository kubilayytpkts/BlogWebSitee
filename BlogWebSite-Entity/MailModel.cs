using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class MailModel
    {
        [Key]
        public int MailID { get; set; }
        public string? SenderMail { get; set; }
        public string? SenderMailPassword { get; set; }
        public string? ReceiverMail { get; set; }
        public string? SMTP { get; set; }
        public int? Port { get; set; }
    }
}
