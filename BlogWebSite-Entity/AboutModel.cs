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
        public int HakkındaID { get; set; }
        public string? HakkındaBaslik { get; set; }
        public string? HakkındaYazi { get; set; }
        public string? HakkındaKısaYazi { get; set; }

    }
}
