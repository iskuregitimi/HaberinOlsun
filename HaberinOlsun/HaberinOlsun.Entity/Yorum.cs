namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int YorumID { get; set; }

        public int? HaberID { get; set; }

        public int? YaziID { get; set; }

        [StringLength(50)]
        public string AdSoyad { get; set; }

        [StringLength(250)]
        public string Yorumyazisi { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Haber Haber { get; set; }

        public virtual KoseYazilari KoseYazilari { get; set; }
    }
}
