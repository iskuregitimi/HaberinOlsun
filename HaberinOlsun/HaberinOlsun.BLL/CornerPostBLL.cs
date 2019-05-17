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

        public static List<KoseYazilari> getOtherCornerPosts(int writerId, int writingId)
        {
            List<KoseYazilari> list = DataContext.getOtherKoseYazilari(writerId,writingId);
            return list;
        }

        public static KoseYazilari getOtherCornerPost(int writerId, int writingId)
        {
            KoseYazilari post = DataContext.getOtherKoseYazisi(writerId, writingId);
            return post;
        }
    }
}
