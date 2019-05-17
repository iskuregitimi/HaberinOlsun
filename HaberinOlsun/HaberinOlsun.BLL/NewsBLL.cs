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
        public static Haberler getNews(int id)
        {
            Haberler haber = DataContext.GetHaber(id);
            return haber;
        }

        public static List<Haberler> getCurrentNews()
        {
            List<Haberler> list = DataContext.getCurrentHaber();
            return list;
        }

        public static List<Haberler> getAllCurrents()
        {
            List<Haberler> list = DataContext.getCurrentHaber();
            return list;
        }

        public static void updateReadingNum(int id)
        {
            Haberler haber = DataContext.GetHaber(id);
            DataContext.increaseNumberOfReading(haber);
        }

        public static List<Haberler> getNewsbyCategory(int id)
        {
            List<Haberler> list = DataContext.getNewsbyCategory(id);
            return list;
        }
    }
}
