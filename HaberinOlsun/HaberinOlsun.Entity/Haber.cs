namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Haber")]
    public partial class Haber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haber()
        {
            Gundem = new HashSet<Gundem>();
            HaberKategori = new HashSet<HaberKategori>();
            Yorum = new HashSet<Yorum>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(250)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        [Required]
        [StringLength(50)]
        public string Kaynak { get; set; }

        public int OkunmaSayisi { get; set; }

        [Required]
        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundem> Gundem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HaberKategori> HaberKategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }
    }
}
