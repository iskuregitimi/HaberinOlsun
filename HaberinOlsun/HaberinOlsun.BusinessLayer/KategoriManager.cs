using HaberinOlsun.DataAccessLayer.EntityFramework;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BusinessLayer
{
    public class KategoriManager
    {
        Repository<Kategori> repo = new Repository<Kategori>();

        public List<Kategori> GetKategori()
        {
            return repo.List();
        }
    }
}
