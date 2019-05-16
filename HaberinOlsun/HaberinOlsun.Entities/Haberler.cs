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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haberler()
        {
            Kategoris = new HashSet<Kategori>();
        }

        [Key]
        public int HaberId { get; set; }

        [Required]
        [StringLength(100)]
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(255)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        [Required]
        [StringLength(50)]
        public string Kaynak { get; set; }

        public int? OkunmaSayisi { get; set; }

        [Required]
        [StringLength(255)]
        public string ResimUrl { get; set; }

        public virtual Gundem Gundem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategori> Kategoris { get; set; }
    }
}
