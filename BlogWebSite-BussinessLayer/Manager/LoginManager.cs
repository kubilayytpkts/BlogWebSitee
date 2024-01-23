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
	public class LoginManager : IGenericService<UserModel>
	{
		IUserDal userDal;

        public LoginManager(IUserDal _userDal)
        {
			userDal = _userDal;
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
			throw new NotImplementedException();
		}

		public List<UserModel> ListAll()
		{
			throw new NotImplementedException();
		}
		public UserModel GetAdminInformation(string mail,string password)
		{
			var result = userDal.GetListAll().Where(x => x.password == password && x.Mail == mail).FirstOrDefault();

			return result;
		}

		public void Update(UserModel value)
		{
			throw new NotImplementedException();
		}
	}
}
