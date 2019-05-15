using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberci.BLL
{
    public static class Haber
    {
        public static List<Haberler> GetHaberlers()
        {

            DataContext db = new DataContext();
            return db.Haberler.ToList();
        }

    }  

}
