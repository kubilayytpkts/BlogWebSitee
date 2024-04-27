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
	public class CommentManager :ICommentService
	{
		ICommentDal commentDal;
        public CommentManager(ICommentDal _commentDal)
        {
		 commentDal = _commentDal;
        }

		public void Add(CommentModel value)
		{
			commentDal.Insert(value);
		}

		public void Delete(CommentModel value)
		{
			throw new NotImplementedException();
		}

		public CommentModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<CommentModel> ListAll(int id)
		{
			var resultValue = commentDal.GetListAll(x => x.BlogID == id).SelectMany(y => y.Blog.Comment).ToList();
			return resultValue;
		}

		public List<CommentModel> ListAll()
		{
			throw new NotImplementedException();
		}

		public bool Update(CommentModel value)
		{
			return true;
		}
	}
}
