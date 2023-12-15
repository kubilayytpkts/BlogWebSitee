using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class BlogModel
    {
        public string BlogID { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogImage { get; set; }
        public DateTime? BlogDateTime { get; set; }
        public string? BlogDescription { get; set; }
        public bool Status { get; set; }
    }
}
