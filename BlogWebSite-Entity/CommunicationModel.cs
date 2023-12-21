using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
	public class CommunicationModel
	{
        [Key]
        public int ComID { get; set; }
        public string ComName { get; set; }
        public string ComEmail { get; set; }
        public DateTime ComDateTime { get; set; }
        public string ComDescription { get; set; }
    }
}
