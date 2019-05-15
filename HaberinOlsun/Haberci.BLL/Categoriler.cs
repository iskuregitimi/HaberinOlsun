using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberci.BLL
{
   public static  class Categoriler
    {
       static  DataContext db = new DataContext();
        
        public static List<Kategori> getkategori()
        {
            return db.Kategori.ToList();
        }
    }
}
