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
	public class AboutManager : IGenericService<AboutModel>
	{
		IAboutDal aboutDal;
        public AboutManager(IAboutDal _aboutDal)
        {
			aboutDal = _aboutDal;
        }
        public void Add(AboutModel value)
		{
			aboutDal.Insert(value);
		}

		public void Delete(AboutModel value)
		{
			aboutDal.Delete(value);
		}

		public AboutModel GetById(int id)
		{
			return aboutDal.GetById(id);
		}

		public List<AboutModel> ListAll()
		{
			return aboutDal.GetListAll();
		}

		public bool Update(AboutModel value)
		{
			aboutDal.Update(value);
			return true;
		}
	}
}
