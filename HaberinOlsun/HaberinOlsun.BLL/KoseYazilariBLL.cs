using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
	public class KoseYazilariBLL
	{

		RepositoryPattern<KoseYazilari> repo = new RepositoryPattern<KoseYazilari>();
		public List<KoseYazilari> GetKoseYazilari(int id)
		{
			return repo.List(x => x.YaziId== id);
		}
		public List<KoseYazilari> GetKoseYazilari()
		{
			return repo.List();
		}



	}
}
