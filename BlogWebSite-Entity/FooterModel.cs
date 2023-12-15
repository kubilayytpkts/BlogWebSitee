using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class FooterModel
    {
        [Key]
        public int FooterID { get; set; }
        public string FooterImage { get; set; }
        public string Phone{ get; set; }
    }
}
