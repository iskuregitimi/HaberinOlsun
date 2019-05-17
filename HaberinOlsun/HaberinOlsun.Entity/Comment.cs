namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int CommentId { get; set; }

        public int? HaberId { get; set; }

        public int? YaziId { get; set; }

        [Required]
        [StringLength(50)]
        public string Gonderen { get; set; }

        [Required]
        [StringLength(500)]
        public string Yorum { get; set; }

        public DateTime Tarih { get; set; }

        public virtual Haberler Haberler { get; set; }

        public virtual KoseYazilari KoseYazilari { get; set; }
    }
}
