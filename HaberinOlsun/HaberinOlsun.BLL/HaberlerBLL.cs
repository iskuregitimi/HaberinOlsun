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
        Repository<Haberler> repo = new Repository<Haberler>();

        public List<Haberler> GetHaberler()
        {
            return repo.List();
        }

        public Haberler GetHaber(int id)
        {
            return repo.Find(x => x.HaberId == id);
        }

        public List<Haberler> GetHaberlerListesi(int id)
        {
            return repo.List(x => x.HaberId == id);
        }
        
    }
}
