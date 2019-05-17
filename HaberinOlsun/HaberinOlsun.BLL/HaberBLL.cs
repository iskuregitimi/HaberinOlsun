using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class HaberBLL
    {
        static DataContext datacontext = new DataContext();
        public static List<Haberler> haber()
        {
            return datacontext.Haberler.OrderByDescending(x=>x.Tarih.Value).ToList();
        }
        public static List<Haberler> getHaber(int categoriId )
        {
          
                var d = (from a in datacontext.Haberler
                         join b in datacontext.HaberKategori
                         on a.HaberID equals b.HaberID
                         where b.KategoriID == categoriId
                         select a).ToList();
                return d;
           

        }
        public static Haberler haberdetay(int id)
        {
            return datacontext.Haberler.FirstOrDefault(x => x.HaberID == id);
        }


        public static HaberKategori katHaber(int id)
        {
            return datacontext.HaberKategori.Where(x => x.KategoriID == id).FirstOrDefault();
        }
        public static void haberGüncelle(Haberler haber)
        {
            datacontext.SaveChanges();
        }
    }
}
