using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class CornerPostBLL
    {
        public static KoseYazilari getCornerPost(int id)
        {
            KoseYazilari post = DataContext.getKoseYazisi(id);
            return post;
        }
        public static List<KoseYazilari> getCornerPosts(int id)
        {
            List<KoseYazilari> list = DataContext.getKoseYazilari(id);
            return list;
        }
    }
}
