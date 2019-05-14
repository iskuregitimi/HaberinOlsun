using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
  public static  class HaberBLL
    {
        static DataContext datacontext = new DataContext();
        public static List<Haberler> getHaber()
        {
            return datacontext.Haberler.ToList();
        }
        public static Haberler haberdetay(int id)
        {
            return datacontext.Haberler.FirstOrDefault(x => x.HaberID == id);
        }

    }
}
