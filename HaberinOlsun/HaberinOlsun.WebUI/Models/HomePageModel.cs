using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.WebUI.Models
{
    public class HomePageModel
    {
        public List<Haberler> Haberler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Yazarlar> Yazarlar { get; set; }
        public List<Gundem> Gundemler { get; set; }
        public List<KoseYazilari> KoseYazilari { get; set; }
        public Haberler Haber { get; set; }
        public KoseYazilari KoseYazisi { get; set; }
    }
}