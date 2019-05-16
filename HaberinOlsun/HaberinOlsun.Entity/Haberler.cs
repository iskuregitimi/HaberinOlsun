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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haberler()
        {
            Gundems = new HashSet<Gundem>();
            HaberKategoris = new HashSet<HaberKategori>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundem> Gundems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HaberKategori> HaberKategoris { get; set; }
    }
}
