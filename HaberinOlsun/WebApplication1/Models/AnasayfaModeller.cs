using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AnasayfaModeller
    {
        public List<Kategori> Kategori { get; set; }
        public List<Yazarlar> Yazarlar { get; set; }
        public List<Gundem> Gundem { get; set; }
        public List<KoseYazilari> KoseYazilari { get; set; }
        public List<Haberler> Haberler { get; set; }
        public List<RssHaberModel> RssHaber { get; set; }


    }
}