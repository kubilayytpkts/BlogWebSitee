using BlogWebSite.DataAccess.Abstract;
using BlogWebSite.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DataAccess.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Delete(T value)
		{
			var context = new Context();
			context.Remove(value);
			context.SaveChanges();
		}

		public T GetById(int id)
		{
			var context=new Context();
			var value = context.Set<T>().Find(id);
			return value;

		}

		public List<T> GetListAll()
		{
			var context =new Context();
			var value = context.Set<T>().ToList();
			return value;
		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			var context = new Context();
			var value = context.Set<T>().Where(filter).ToList();
			return value;
		}

		public void Insert(T value)
		{
			var context = new Context();
			context.Add(value);
			context.SaveChanges();
		}

		public void Update(T value)
		{
			var context = new Context();
			context.Update(value);
			context.SaveChanges();
		}
	}
}