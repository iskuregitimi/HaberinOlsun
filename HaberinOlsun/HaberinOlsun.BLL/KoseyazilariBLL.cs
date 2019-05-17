using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class KoseyazilariBLL
    {
        Repository<KoseYazilari> repo = new Repository<KoseYazilari>();

        public List<KoseYazilari> GetKoseYazilari()
        {
            return repo.List();
        }
        public List<KoseYazilari> GetKoseYazilariListesi(int id)
        {
            return repo.List(x=>x.YaziId==id);
        }
        public KoseYazilari GetKoseYazisi(int id)
        {
            return repo.Find(x => x.YaziId== id);
        }
    }
}
