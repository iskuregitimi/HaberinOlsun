using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class CurrentBLL
    {
        public static List<Gundem> getCurrents()
        {
            List<Gundem> list = DataContext.GetGundems();
            return list;
        }
    }
}
