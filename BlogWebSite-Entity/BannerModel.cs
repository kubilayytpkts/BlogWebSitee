using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
	public class BannerModel
	{
		[Key]
		public int BannerID { get; set; }
		public string? BannerPhoto { get; set; }
		public string? ShortHelloText { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? BannerShortAbout { get; set; }
		public string? BannerShortAbout1 { get; set; }
    }
}
