using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
   public class KategoriManager
    {
        DataContext dc = new DataContext();
        public List<Kategori> GetKategories()
        {
           return dc.Kategoris.ToList();
        }
    }
}
