using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class AboutModel
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutPhoto { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutText { get; set; }
        public string? AboutShortText { get; set; }
        public string? UserStatusTitle { get; set; }

    }
}
