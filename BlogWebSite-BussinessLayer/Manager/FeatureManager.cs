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
	public class FeatureManager : IGenericService<FeatureCounterModel>
	{
		IFeatureCounterDal featureCounterDal;
        public FeatureManager(IFeatureCounterDal _featureCounterDal)
        {
			featureCounterDal = _featureCounterDal;
        }
        public void Add(FeatureCounterModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(FeatureCounterModel value)
		{
			throw new NotImplementedException();
		}

		public FeatureCounterModel GetById(int id)
		{
			 return featureCounterDal.GetById(id);
		}

		public List<FeatureCounterModel> ListAll()
		{
			return featureCounterDal.GetListAll();
		}

		public bool Update(FeatureCounterModel value)
		{
			if(value != null)
			{
                featureCounterDal.Update(value);
				return true;
			}
			else
				return false;
		}
	}
}
