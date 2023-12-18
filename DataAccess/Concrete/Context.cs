using BlogWebSite_Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogWebSite.DataAccess.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-PJ2UI5D;database=CoreBlogDB;integrated security=true");
		}
		public DbSet<AboutModel> Abouts { get; set; }
		public DbSet<BannerModel> Banners { get; set; }
		public DbSet<BlogModel> Blogs { get; set; }
		public DbSet<CategoryModel>Categorys { get; set; }
		public DbSet<FeatureCounterModel> FeatureCounters { get; set; }
        public DbSet<FooterModel>Footers { get; set; }
		public DbSet<QuotesModel> Quotes { get; set; }
		public DbSet<SocialMediaModel> SocialMedias { get; set; }
		public DbSet<UserModel> Users { get; set; }
    }
} 
