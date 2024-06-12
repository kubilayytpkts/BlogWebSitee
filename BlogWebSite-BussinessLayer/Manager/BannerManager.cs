using BlogWebSite.DataAccess.Abstract;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Manager
{
	public class BannerManager : IGenericService<BannerModel>
	{
		IBannerDal bannerDal;
        public BannerManager(IBannerDal _bannerDal)
        {
				bannerDal=_bannerDal;
        }

        public void Add(BannerModel value)
		{
			bannerDal.Insert(value);
		}

		public void Delete(BannerModel value)
		{
			bannerDal.Delete(value);
		}

		public BannerModel GetById(int id)
		{
		    return bannerDal.GetById(id);
		}

		public List<BannerModel> ListAll()
		{
			return bannerDal.GetListAll();
		}

		public bool Update(BannerModel value)
		{
			bannerDal.Update(value);
			return true;
		}

		public bool Change_Product_WithImage(BannerModel banner,IFormFile bannerPhoto)
		{
            var fileExtension = Path.GetExtension(bannerPhoto.FileName);

            var fileName = Guid.NewGuid().ToString() + fileExtension;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/author", "images", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                bannerPhoto.CopyTo(stream);
            }

            var result = GetById(1);

            result.Name = banner.Name;
            result.Surname = banner.Surname;
            result.BannerPhoto = "/author/images/" + fileName;
            result.BannerShortAbout = banner.BannerShortAbout;
            result.BannerShortAbout1 = banner.BannerShortAbout1;

            Update(result);

			return true;
        }
	}
}
