using HaberinOlsun.DAL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public static class NewsBLL
    {
        public static Haberler getNews()
        {
            Haberler haber = DataContext.GetHaber();
            return haber;
        }
    }
}
