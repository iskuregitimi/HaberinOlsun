using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class PostsBLL
    {
        public static HaberinOlsunDbEntity db = new HaberinOlsunDbEntity();
        public static List<Haberler> GetPosts()
        {
            return (db.Haberlers.ToList());
        }
        
        public static object GetSelectedPost(int HaberID)
        {
            var getpostdata = db.Haberlers.Where(x => x.HaberID == HaberID).FirstOrDefault();
            var updatecount = getpostdata.OkunmaSayisi + 1;
            db.SaveChanges();
            return (getpostdata);
        }

        public static List<Haberler> GetRandomPost()
        {
            Random r = new Random();
            List<Haberler> haber = new List<Haberler>();
            for (int i = 1; i < 10; i++)
            {
                int haberid = r.Next(1, 10);
                var haberler = db.Haberlers.Where(x => x.HaberID == haberid);
                haber.Add(haberler.FirstOrDefault());
            }
            
            return (haber);
        }

        public static List<Yazarlar> getAuthors()
        {
            return(db.Yazarlars.ToList());
        }

        public static List<Kategori> getCategories()
        {
            return (db.Kategoris.ToList());
        }

        public static List<KoseYazilari> getCornerPosts(int Yazarid)
        {
            return (db.KoseYazilaris.Where(x => x.YazarID == Yazarid).ToList()); 
        }

    }
}
