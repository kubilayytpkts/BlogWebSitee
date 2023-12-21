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
	public class UserManager : IGenericService<UserModel>
	{
		IUserDal userDal;
        public UserManager(IUserDal _userDal)
        {
		  userDal=_userDal;
        }
        public void Add(UserModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(UserModel value)
		{
			throw new NotImplementedException();
		}

		public UserModel GetById(int id)
		{
			return userDal.GetById(id);
		}

		public List<UserModel> ListAll()
		{
			return userDal.GetListAll();
		}

		public void Update(UserModel value)
		{
			throw new NotImplementedException();
		}
	}
}
