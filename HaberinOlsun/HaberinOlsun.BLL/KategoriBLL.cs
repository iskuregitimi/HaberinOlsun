using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class KategoriBLL
    {
        static DataContext db = new DataContext();

        public static List<Kategori> GetKAtegori()
        {
            return db.Kategori.ToList();
        }
        public static Kategori GetKAtegori(int id)
        {
            return db.Kategori.Where(x => x.KategoriID == id).FirstOrDefault();
        }
    }
}
