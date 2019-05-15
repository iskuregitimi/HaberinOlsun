using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberci.BLL
{
   public static class KoseyazisiBLL
    {
        public static List<KoseYazilari> GetKoseYazilariDetails(int YazarId)
        {
            DataContext db = new DataContext();
            return db.KoseYazilari.Where(x => x.YazarId == YazarId).ToList();

        }

    }
}
