﻿using BlogWebSite.DataAccess.Abstract;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Manager
{
	public class SocialMediaManager : IGenericService<SocialMediaModel>
	{
		ISocialMediaDal socialMediaDal;
        public SocialMediaManager(ISocialMediaDal _socialMediDal)
        {
			socialMediaDal=_socialMediDal;
        }

        public void Add(SocialMediaModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(SocialMediaModel value)
		{
			throw new NotImplementedException();
		}

		public SocialMediaModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<SocialMediaModel> ListAll()
		{
			return socialMediaDal.GetListAll();
		}

		public void Update(SocialMediaModel value)
		{
			throw new NotImplementedException();
		}
	}
}
