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
    public class CategoryManager : IGenericService<CategoryModel>
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public void Add(CategoryModel value)
        {
            throw new NotImplementedException();
        }

        public void Delete(CategoryModel value)
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> ListAll()
        {
            return categoryDal.GetListAll();
        }

        public bool Update(CategoryModel value)
        {
            return true;
        }
    }
}
