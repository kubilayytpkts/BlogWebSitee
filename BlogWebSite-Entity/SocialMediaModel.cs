using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class SocialMediaModel
    {
        [Key]
        public int SocialMediID { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string YoutubeLink { get; set; }
    }
}
