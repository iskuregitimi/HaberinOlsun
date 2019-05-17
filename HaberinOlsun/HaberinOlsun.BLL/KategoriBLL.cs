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
        Repository<Kategori> repo = new Repository<Kategori>();

        public List<Kategori> GetKategoriler()
        {
            return repo.List();
        }
        public List<Kategori> GetKategoriListesi(int id)
        {
            return repo.List(x => x.KategoriId == id);
        }
        public Kategori GetKategori(int id)
        {
            return repo.Find(x => x.KategoriId == id);
        }
    }
}
