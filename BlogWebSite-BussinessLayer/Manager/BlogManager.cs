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
	public class BlogManager : IGenericService<BlogModel>
	{
		IBlogDal blogDal;
        public BlogManager(IBlogDal  _blogDal)
        {
		blogDal = _blogDal;
        }
        public void Add(BlogModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(BlogModel value)
		{
			throw new NotImplementedException();
		}

		public BlogModel GetById(int id)
		{
            return blogDal.GetById(id);

        }

		public List<BlogModel> ListAll()
		{
			return blogDal.GetListAll();
		}

		public bool Update(BlogModel value)
		{
			return true;
		}
	}
}
