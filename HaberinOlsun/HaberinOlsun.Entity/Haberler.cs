namespace HaberinOlsun.Entity
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
        public int HaberId { get; set; }

        [Required]
        [StringLength(100)]
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        [Required]
        [StringLength(50)]
        public string Kaynak { get; set; }

        public int OkumaSayisi { get; set; }

        [Required]
        [StringLength(250)]
        public string ResimURL { get; set; }
    }
}
