using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI.Models
{
    public class HaberYorumModel
    {
        public List<Yorum> Yorumlar { get; set; }
        public Yorum Yorum { get; set; }
        public int ID { get; set; }
        public string Tipi { get; set; }
    }
}