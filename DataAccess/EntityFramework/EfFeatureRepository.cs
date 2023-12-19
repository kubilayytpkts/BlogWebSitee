using BlogWebSite.DataAccess.Abstract;
using BlogWebSite.DataAccess.Repositories;
using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DataAccess.EntityFramework
{
	public class EfFeatureRepository:GenericRepository<FeatureCounterModel>,IFeatureCounterDal
	{
	}
}
