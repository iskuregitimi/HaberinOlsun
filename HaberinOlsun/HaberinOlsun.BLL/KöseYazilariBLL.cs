using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class KöseYazilariBLL
    {
        static DataContext DataContext = new DataContext();
        public static List<KoseYazilari> GetKöseYazilaris()
        {
            return DataContext.KoseYazilari.ToList();
        }
        public static KoseYazilari detaykoseYazilari(int id)
        {
            return DataContext.KoseYazilari.FirstOrDefault(x => x.YaziID == id);
        }
        //public  static KoseYazilari kyazilari()
        //{
        //    r
        //}
    }
}
