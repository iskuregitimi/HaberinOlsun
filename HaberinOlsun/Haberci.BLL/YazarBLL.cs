using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberci.BLL
{
   public  class YazarBLL
    {
        public static List<Yazarlar> yazargetir()
        {
            DataContext db = new DataContext();
            return db.Yazarlar.ToList();


        }
       

    }
}
