using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class PhotoModel
    {
        [Key]
        public int FotografID  { get; set; }
        public string? GirisFotograf { get; set; }
        public string? HakkındaFotograf { get; set; }
        public string? HakkındaFotograf1 { get; set; }
        public string? EkFotograf { get; set; }
    }
}
