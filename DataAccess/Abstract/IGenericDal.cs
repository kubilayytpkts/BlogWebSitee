using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DataAccess.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T value);
		void Delete(T value);
		void Update(T value);
		List<T> GetListAll();
		T GetById(int id);
		List<T> GetListAll(Expression<Func<T,bool>>filter);

	}
}
