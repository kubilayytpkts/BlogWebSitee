using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class BlogModel
    {
        [Key]
        public string BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogIcerik { get; set; }
        public string BlogFotograf { get; set; }
        public DateTime BlogTarih { get; set; }
    }
}
