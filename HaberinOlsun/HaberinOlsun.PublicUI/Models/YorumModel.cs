using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI.Models
{
    public class YorumModel
    {
        public string Tip { get; set; }
        public int Id { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public Yorum Yorum { get; set; }
    }
}