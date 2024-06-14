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
			return commentDal.GetById(id);

        }

		public List<CommentModel> ListAll(int id)
		{
			var resultValue = commentDal.GetListAll(x => x.BlogID == id).SelectMany(y => y.Blog.Comment).ToList();
			return resultValue;
		}

		public List<CommentModel> ListAll()
		{
			return commentDal.GetListAll();
		}

		public bool Update(CommentModel value)
		{
            if(value != null)
			{
				commentDal.Update(value);
				return true;
			}

            return false;
        }
		public bool Validation(int id,string type)
		{
			bool flag;
			if(id!=0)
			{
				var result = GetById(id);

                if (type == "deActive")
                {
					result.Status = false;
					Update(result);
					flag = true;
                }
                else
                {
                    result.Status = true;
                    Update(result);
                    flag = true;
                }
            }
			else
			{
                flag = false;
            }

			return flag;
		}
	}
}
