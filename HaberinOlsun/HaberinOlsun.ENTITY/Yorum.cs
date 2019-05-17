namespace HaberinOlsun.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int YorumId { get; set; }

        public int? YaziId { get; set; }

        public int? HaberId { get; set; }

        [Required]
        [StringLength(50)]
        public string Gönderen { get; set; }

        [Required]
        [StringLength(500)]
        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }

        public virtual Haber Haber { get; set; }

        public virtual KoseYazilari KoseYazilari { get; set; }
    }
}
