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
        public static List<Haberler> GetHaberlers()
        {

            DataContext db = new DataContext();
            return db.Haberler.ToList();
        }
        public static Haberler GetDetails(int id)
        {
            DataContext db = new DataContext();
            return db.Haberler.Where(x => x.HaberId == id).FirstOrDefault();
        }
    }  

}
