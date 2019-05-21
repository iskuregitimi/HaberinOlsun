using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI1.Models
{
    public class YorumModel
    {
        public string Tipi{ get; set; }
        public int ID { get; set; }
        public Comments Comment { get; set; }
    }
}