using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI1.Models
{
    public class YorumModel
    {
        public int CommentID { get; set; }
        public int YazıID { get; set; }
        public int HaberID { get; set; }
        public string Gönderen { get; set; }
        public string Yorum { get; set; }
    }
}