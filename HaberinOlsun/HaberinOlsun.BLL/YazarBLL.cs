using HaberinOlsun.DAL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
   public class YazarBLL
    {
        DataContext db = new DataContext();
        public List<Yazar> GetYazars()
        {
            return db.Yazar.ToList();
        }

    }
}
