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
			quotesDal.Delete(value);
        }

		public QuotesModel GetById(int id)
		{
			return quotesDal.GetById(id);
        }

		public List<QuotesModel> ListAll()
		{
			return quotesDal.GetListAll();
		}

		public bool Update(QuotesModel value)
		{
			value.QuotesTitle = "Alıntılar";
            quotesDal.Update(value);
			return true;
        }

		public bool Edit_Quates(QuotesModel value)
		{
			return true;
		}
	}
}
