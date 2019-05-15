using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.DAL
{
	public class RepositoryPattern<T> where T:class
	{

		DataContext db = new DataContext();
		public List<T> List()
		{
			return db.Set<T>().ToList();
		}

		public List<T> List(Expression<Func<T, bool>> where)
		{
			return db.Set<T>().Where(where).ToList();
		}

	}
}