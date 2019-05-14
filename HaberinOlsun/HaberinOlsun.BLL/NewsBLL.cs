using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class NewsBLL
    {
        public static Haberler getNews()
        {
            Haberler haber = DataContext.GetHaber();
            return haber;
        }

        public static List<Haberler> getAllNews()
        {
            List<Haberler> list= DataContext.getAllHaber();
            return list;
        }

        public static List<Gundem> getAllCurrents()
        {
            List<Gundem> list = DataContext.getAllGundems();
            return list;
        }
    }
}
