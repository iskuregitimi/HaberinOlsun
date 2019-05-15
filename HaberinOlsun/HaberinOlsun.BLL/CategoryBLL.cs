using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class CategoryBLL
    {
        public static List<Kategori> getCategories()
        {
            List<Kategori> list = DataContext.GetKategoris();
            return list;
        }
    }
}
