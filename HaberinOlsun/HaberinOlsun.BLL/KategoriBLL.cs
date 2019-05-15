using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class KategoriBLL
    {
        DataContext db = new DataContext();

        public List<Kategori> GetKategori()
        {
            return db.Kategori.ToList();
        }

        public Kategori GetKategori(int id)
        {
            return db.Kategori.FirstOrDefault(x=>x.KategoriId == id);
        }
    }
}
