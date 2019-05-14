using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
  public static  class YazarlarBLL
    {
        static DataContext DataContext = new DataContext();



        public static List<Yazarlar> GetYazarlars()
        {
            return DataContext.Yazarlar.ToList();
        }
    }
}
