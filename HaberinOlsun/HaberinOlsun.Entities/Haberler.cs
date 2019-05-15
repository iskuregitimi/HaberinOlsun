namespace HaberinOlsun.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Haberler")]
    public partial class Haberler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HaberId { get; set; }

        [StringLength(250)]
        public string Baslik { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(250)]
        public string Ozet { get; set; }

        public string Detay { get; set; }

        [StringLength(50)]
        public string Kaynak { get; set; }

        public int? OkunmaSayisi { get; set; }

        [StringLength(250)]
        public string ResimURL { get; set; }
        
        public virtual Gundem Gundem { get; set; }

        public virtual HaberKategori HaberKategori { get; set; }
    }
}
