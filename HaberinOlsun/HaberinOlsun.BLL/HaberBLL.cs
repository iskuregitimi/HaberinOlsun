using HaberinOlsun.DAL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
   public class HaberBLL
        
    {
        DataContext db = new DataContext();
        public List<Haber> GetHabers()
        {
            return db.Haber.ToList();
        }

        public Haber GetHaber(int Id)
        {
            return db.Haber.Where(x => x.HaberId == Id).FirstOrDefault();
        }
    }
}
