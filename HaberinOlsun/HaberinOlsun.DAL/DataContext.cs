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
            return context.Haberlers.ToList();
        }

        public static List<Kategori> GetKategoris()
        {
            return context.Kategoris.ToList();
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
    }
}
