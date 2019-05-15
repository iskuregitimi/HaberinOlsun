using HaberinOlsun.DAL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
   public class KoseYazisiBLL
    {
        DataContext db = new DataContext();  
        public List<KoseYazilari> GetKoseYazilaris()
        {
            return db.KoseYazilari.ToList();
        }

        public KoseYazilari GetKoseYazilari(int Id)
        {
            return db.KoseYazilari.FirstOrDefault(x=>x.YaziId==Id);
        }
    }
}
