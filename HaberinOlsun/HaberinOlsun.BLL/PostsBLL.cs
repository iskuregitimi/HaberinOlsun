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
        
        public static Haberler GetSelectedPost(int HaberID)
        {
            var getpostdata = db.Haberlers.Where(x => x.HaberID == HaberID).FirstOrDefault();
            getpostdata.OkunmaSayisi = getpostdata.OkunmaSayisi + 1;
            db.SaveChanges();
            var getpost = getpostdata;
            return (getpost);
        }

        public static List<Yazarlar> getAuthors()
        {
            return(db.Yazarlars.ToList());
        }
    }
}
