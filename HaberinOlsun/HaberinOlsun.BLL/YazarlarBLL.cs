using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class YazarlarBLL
    {
        Repository<Yazarlar> repo = new Repository<Yazarlar>();

        public List<Yazarlar> GetYazarlar()
        {
            return repo.List();
        }
        public Yazarlar GetYazar(int id)
        {
            return repo.Find(x => x.YazarId == id);
        }
    }
}
