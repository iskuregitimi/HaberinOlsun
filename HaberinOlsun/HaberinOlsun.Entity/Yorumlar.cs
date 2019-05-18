namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorumlar")]
    public partial class Yorumlar
    {
        [Key]
        public int commentID { get; set; }

        public int? yaziID { get; set; }

        public int? haberID { get; set; }

        [Required]
        [StringLength(50)]
        public string gonderen { get; set; }

        [Required]
        [StringLength(500)]
        public string yorum { get; set; }

        public DateTime tarih { get; set; }

        public virtual Haberler Haberler { get; set; }

        public virtual KoseYazilari KoseYazilari { get; set; }
    }
}
