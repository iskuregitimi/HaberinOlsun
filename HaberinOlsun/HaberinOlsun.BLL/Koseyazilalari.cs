using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class Koseyazilalari
    {
        Repository<KoseYazilari> repo = new Repository<KoseYazilari>();

        public List<KoseYazilari> GetKoseYazilari()
        {
            return repo.List();
        }
    }
}
