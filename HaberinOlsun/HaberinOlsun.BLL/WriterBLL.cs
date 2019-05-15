using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class WriterBLL
    {
        public static List<Yazarlar> getCategories()
        {
            List<Yazarlar> list = DataContext.GetYazarlars();
            return list;
        }
    }
}
