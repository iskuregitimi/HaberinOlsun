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
        public int HaberID { get; set; }

        [Required]
        [StringLength(250)]
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(250)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        [Required]
        [StringLength(100)]
        public string Kaynak { get; set; }

        public Int64? OkunmaSayisi { get; set; }

        [StringLength(250)]
        public string ResimURL { get; set; }

        public virtual Gundem Gundem { get; set; }

        public virtual HaberKategori HaberKategori { get; set; }
    }
}
