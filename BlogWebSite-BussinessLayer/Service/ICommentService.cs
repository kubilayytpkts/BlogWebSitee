using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Service
{
	public interface ICommentService:IGenericService<CommentModel>
	{
		public List<CommentModel> ListAll(int id);
	}
}
