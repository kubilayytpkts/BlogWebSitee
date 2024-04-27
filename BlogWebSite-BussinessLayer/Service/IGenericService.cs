using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Service
{
	public interface IGenericService<T>
	{
		void Add(T value);
		void Delete(T value);
		List<T>ListAll();
		T GetById(int id);
		bool Update(T value);
	}
}
