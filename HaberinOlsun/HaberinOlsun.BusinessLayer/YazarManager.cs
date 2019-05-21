using HaberinOlsun.DataAccessLayer.EntityFramework;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BusinessLayer
{
    public class YazarManager
    {
        Repository<Yazarlar> repo = new Repository<Yazarlar>();

        public List<Yazarlar> GetYazars()
        {
            return repo.List();
        }

        public Yazarlar GetYazar(int id)
        {
            return repo.Find(x => x.ID == id);
        }
    }
}
