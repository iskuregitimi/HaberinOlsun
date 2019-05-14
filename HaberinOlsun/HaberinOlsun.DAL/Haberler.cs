namespace HaberinOlsun.DAL
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
            Gundem = new HashSet<Gundem>();
            Kategori = new HashSet<Kategori>();
        }

        [Key]
        public int HaberID { get; set; }

        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(1000)]
        public string Ozet { get; set; }

        [Required]
        [StringLength(250)]
        public string Kaynak { get; set; }

        [Required]
        public string Detay { get; set; }

        public int OkunmaSayisi { get; set; }

        [Required]
        [StringLength(50)]
        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundem> Gundem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategori> Kategori { get; set; }
    }
}
