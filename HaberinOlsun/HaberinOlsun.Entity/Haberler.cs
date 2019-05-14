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
            Gundem = new HashSet<Gundem>();
            HaberKategori = new HashSet<HaberKategori>();
        }

        [Key]
        public int HaberId { get; set; }

        [StringLength(250)]
        public string Baslik { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(250)]
        public string Ozet { get; set; }

        public string Detay { get; set; }

        [StringLength(250)]
        public string Kaynak { get; set; }

        public int? OkunmaSayisi { get; set; }

        [StringLength(250)]
        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundem> Gundem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HaberKategori> HaberKategori { get; set; }
    }
}
