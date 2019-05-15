using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI1.Models
{
    public class AnasayfaModel
    {
        public List<Haberler> Haberler { get; set; }

        public List<Kategori> Kategoriler { get; set; }
        public List<Yazarlar> Yazarlar { get; set; }
        public List<KoseYazilari> KoseYazilari { get; set; }
        public Haberler haber { get; set; }
        public KoseYazilari kyazilari{ get; set; }

    }
}