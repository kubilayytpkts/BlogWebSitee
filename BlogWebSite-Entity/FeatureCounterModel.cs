using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class FeatureCounterModel
    {
        [Key]
        public int FeatureID { get; set; }
        public string? FeatureTitle { get; set; }
        public string? ReadBook { get; set; }
        public string? ReadArticlePage { get; set; }
        public string? AdditionalLanguage { get; set; }
        public string? Activity { get; set; }
    }
}
