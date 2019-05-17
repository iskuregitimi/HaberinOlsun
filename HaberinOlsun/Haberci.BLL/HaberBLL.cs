using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberci.BLL
{
    public static class HaberBLL
    {
        static DataContext db = new DataContext();

        public static List<Haberler> GetHaberlers()
        {

           
            return db.Haberler.ToList();
        }
        public static Haberler GetDetails(int id)
        {
           


            return db.Haberler.Where(x => x.HaberId == id).FirstOrDefault();
        }
        public static void HaberlerIdArtması(Haberler haberler)
        {

            db.SaveChanges();
        }

    }
}
