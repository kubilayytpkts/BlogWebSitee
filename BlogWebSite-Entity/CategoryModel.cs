using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
	public class CategoryModel
	{
		[Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription{ get; set; }
        public bool Status { get; set; }
        public List<BlogModel> Blog { get; set; }
    }
}
