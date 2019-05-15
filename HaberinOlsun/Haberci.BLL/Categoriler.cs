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
        public static  Kategori Categorigetir (int Categoriid)
        {
         Kategori kat = db.Kategori.Where(x => x.KategoriId == Categoriid).FirstOrDefault();
          return kat;
        }
        public static List<Kategori> getkategori()
        {
            return db.Kategori.ToList();
        }
    }
}
