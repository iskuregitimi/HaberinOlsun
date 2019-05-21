using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI.Models
{
    public class IndexModel
    {
        public List<Haber> Haberler { get; set; }
        public List<Yazarlar> Yazarlar { get; set; }
    }
}