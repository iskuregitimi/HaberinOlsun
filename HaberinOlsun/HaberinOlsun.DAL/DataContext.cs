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

        public static Haberler GetHaber()
        {
            return context.Haberlers.Where(x => x.HaberId == 1).FirstOrDefault();
        }
    }
}
