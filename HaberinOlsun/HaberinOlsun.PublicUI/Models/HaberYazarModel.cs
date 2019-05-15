using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI.Models
{
    public class HaberYazarModel
    {
        public List<Haber> Habers { get; set; }
        public List<Yazar> Yazars { get; set; }
        public List<KoseYazilari> KoseYazilaris { get; set; }
        public List<Kategori> Kategoris { get; set; }
    }
}