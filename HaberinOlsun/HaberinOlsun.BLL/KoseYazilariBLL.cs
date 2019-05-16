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
		public List<KoseYazilari> GetKoseYazilariListesi(int id)
		{
			return repo.List(x => x.YaziId== id);
		}
		public List<KoseYazilari> GetKoseYazilari()
		{
			return repo.List();
		}
		public KoseYazilari GetKoseYazilariDetay(int id)
		{
			return repo.Find(x=> x.YaziId==id);
		}

		public List<KoseYazilari> GetKoseYazilarList(int id)
		{
			return repo.List(x=> x.YazarId==id);
		}
		
	}
}
