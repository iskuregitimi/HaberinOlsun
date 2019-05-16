using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.UI.Models
{
    public class HomePageModel
    {
        public List<Haberler> Haberler { get; set; }
        public List<Yazarlar> Yazarlar { get; set; }
        public Haberler haber { get; set; }
        public List<Kategori> kategori { get; set; }

    }
}