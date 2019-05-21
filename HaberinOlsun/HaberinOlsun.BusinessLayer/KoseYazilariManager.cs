using HaberinOlsun.DataAccessLayer.EntityFramework;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BusinessLayer
{
    public class KoseYazilariManager
    {
        Repository<KoseYazilari> repo = new Repository<KoseYazilari>();

        public List<KoseYazilari> GetKoseYazilari(int id)
        {
            return repo.List(x => x.YazarID == id);
        }

        public KoseYazilari GetKoseYazisi(int id)
        {
            return repo.Find(x => x.ID == id);
        }
    }
}
