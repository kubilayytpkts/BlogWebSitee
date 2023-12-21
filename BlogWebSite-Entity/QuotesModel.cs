using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class QuotesModel
    {
		[Key]
		public int QuotesID { get; set; }
        public string QuotesTitle { get; set; }
        public string QuotesDescription { get; set; }
        public string QuotesWriterName { get; set; }
        public bool Status { get; set; }
    }
}
