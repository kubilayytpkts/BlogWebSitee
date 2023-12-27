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
		public int BlogID { get; set; }
		public string? BlogTitle { get; set; }
		public string? BlogImage { get; set; }
		public string? BlogThumbnailImage { get; set; }
		public DateTime? BlogDateTime { get; set; }
		public string? BlogDescription { get; set; }
		public bool Status { get; set; }
        public int CategoryID { get; set; }
        public CategoryModel Category { get; set; }
        public List<CommentModel> Comment{ get; set; }
    }
}
