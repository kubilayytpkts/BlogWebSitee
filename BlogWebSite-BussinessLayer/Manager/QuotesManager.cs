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
	public class QuotesManager : IGenericService<QuotesModel>
	{
		IQuotesDal quotesDal;
        public QuotesManager(IQuotesDal _quotesDal)
        {
				quotesDal = _quotesDal;
        }

        public void Add(QuotesModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(QuotesModel value)
		{
			throw new NotImplementedException();
		}

		public QuotesModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<QuotesModel> ListAll()
		{
			return quotesDal.GetListAll();
		}

		public void Update(QuotesModel value)
		{
			throw new NotImplementedException();
		}
	}
}
