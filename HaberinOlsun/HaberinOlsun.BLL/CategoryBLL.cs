using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class CategoryBLL
    {
        public static HaberinOlsunDbEntity db = new HaberinOlsunDbEntity();
        public static List<Haberler> getpostsfromcategory(int KategoriID)
        {
            var getpostsfromcategory = from p in db.Haberlers
                                       join h in db.HaberKategoris on p.HaberID equals h.HaberID
                                       where h.KategoriID == KategoriID
                                       select p;

            
            return (getpostsfromcategory.ToList());
        }
    }
}
