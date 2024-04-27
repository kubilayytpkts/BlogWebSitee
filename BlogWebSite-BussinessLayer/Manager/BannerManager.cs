using BlogWebSite.DataAccess.Abstract;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
