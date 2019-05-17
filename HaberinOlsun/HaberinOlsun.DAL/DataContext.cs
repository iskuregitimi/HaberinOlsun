using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.DAL
{
    public static class DataContext
    {
        static HaberModel context = new HaberModel();

        public static Haberler GetHaber(int haberId)
        {
            return context.Haberlers.Where(x => x.HaberId == haberId).FirstOrDefault();
        }

        public static List<Haberler> getCurrentHaber()
        {
            return context.Haberlers.OrderByDescending(c => c.Tarih.Value).ToList();
        }

        public static List<Kategori> GetKategoris()
        {
            return context.Kategoris.ToList();
        }

        public static Kategori GetKategori(int categoryId)
        {
            return context.Kategoris.Where(x => x.KategoriID == categoryId).FirstOrDefault();
        }

        public static List<Yazarlar> GetYazarlars()
        {
            return context.Yazarlars.ToList();
        }

        public static List<Gundem> GetGundems()
        {
            return context.Gundems.ToList();
        }

        public static KoseYazilari getKoseYazisi(int yaziId)
        {
            return context.KoseYazilaris.Where(x => x.YaziId == yaziId).FirstOrDefault();
        }

        public static List<KoseYazilari> getKoseYazilari(int yazarId)
        {
            return context.KoseYazilaris.Where(x => x.YazarId == yazarId).ToList();
        }

        public static void increaseNumberOfReading(Haberler haber)
        {
            haber.OkunmaSayisi = haber.OkunmaSayisi + 1;
            context.SaveChanges();
        }

        public static List<KoseYazilari> getOtherKoseYazilari(int yazarId, int yaziId)
        {
            return context.KoseYazilaris.Where(x => x.YazarId == yazarId && x.YaziId != yaziId).ToList();
        }

        public static KoseYazilari getOtherKoseYazisi(int yazarId, int yaziId)
        {
            return context.KoseYazilaris.Where(x => x.YazarId == yazarId && x.YaziId == yaziId).FirstOrDefault();
        }

        public static List<Haberler> getNewsbyCategory(int categoryId)
        {
            var result = (from h in context.Haberlers
                          join hk in context.HaberKategoris
                          on h.HaberId equals hk.HaberID
                          where hk.KategoriID == categoryId
                          select h).ToList();
            return result;
        }
    }
}

