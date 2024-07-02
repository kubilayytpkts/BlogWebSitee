using BlogWebSite.DataAccess.Abstract;
using BlogWebSite.DataAccess.Concrete;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Manager
{
    public class MailSystemManager : IGenericService<MailModel>
    {
        private IMailSystemDal mailSystemDal;
        public MailSystemManager(IMailSystemDal _mailSystemDal)
        {
            mailSystemDal = _mailSystemDal;
        }
        public void Add(MailModel value)
        {
            mailSystemDal.Insert(value);
        }

        public void Delete(MailModel value)
        {
            mailSystemDal.Delete(value);
        }

        public MailModel GetById(int id)
        {
            var value = mailSystemDal.GetById(id);
            return value;
        }

        public List<MailModel> ListAll()
        {
            var values = mailSystemDal.GetListAll();
            return values;
        }

        public bool Update(MailModel value)
        {
            if(value is not null)
                mailSystemDal.Update(value);
            else
                return false;

            return true;
        }
    }
}
