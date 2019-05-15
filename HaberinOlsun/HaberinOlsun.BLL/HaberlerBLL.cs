using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
public class HaberlerBLL
	{

		RepositoryPattern<Haberler> repo = new RepositoryPattern<Haberler>();

		public List<Haberler> GetHaberler(int id)
		{
			return repo.List(x => x.HaberId == id);
		}


	}
}
