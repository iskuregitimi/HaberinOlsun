using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.Entity
{
    public class HaberKateModel
    {
        public int ID { get; set; }
        
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }
        
        public string Ozet { get; set; }
        
        public string Detay { get; set; }
        
        public string Kaynak { get; set; }

        public int OkunmaSayisi { get; set; }
        
        public string ResimURL { get; set; }
    }
}
