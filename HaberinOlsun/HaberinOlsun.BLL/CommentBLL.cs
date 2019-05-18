using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
	public class CommentBLL
	{
		DataContext db = new DataContext();

		public List<Yorumlar> GetComment(int id )
		{
			return db.Yorumlars.Where(x=> x.commentID==id).ToList();
		}

	}
}
