using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class BannerModel
    {
        public int BannerID { get; set; }
        public string? BannerPhoto { get; set; }
        public string? ShortHelloText{ get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? BannerShortaAbout { get; set; }
    }
}
