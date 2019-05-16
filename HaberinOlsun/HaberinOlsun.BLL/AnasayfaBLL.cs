using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class AnasayfaBLL
    {
        static DataContext db = new DataContext();

        public static List<Haberler> GetNews(string tip)
        {
            if (tip == "All")
            {
                var haber = db.Haberler.OrderByDescending(x => x.Tarih).Take(10);
                return haber.ToList();
            }

            else if (tip=="Hepsi")
            {
                var haber = db.Haberler.OrderByDescending(x => x.Tarih);
                return haber.ToList();
            }

            else
            {
                var haber = db.Haberler.Where(x => x.HaberTipi == tip).OrderByDescending(x => x.Tarih).Take(10);
                return haber.ToList();
            }
        }

        public static List<Yazarlar> GetYazar()
        {
            var yazar = db.Yazarlar.OrderByDescending(x => x.AdiSoyadi);
            return yazar.ToList();
        }
    }
}
