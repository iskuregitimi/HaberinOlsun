using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.WEBUI.Models
{
    public class YorumModel
    {
        public int Id { get; set; }
        public string Tipi { get; set; }
        public List<Comment> Yorumlar { get; set; }
        public Comment Yorum { get; set; }
    }
}