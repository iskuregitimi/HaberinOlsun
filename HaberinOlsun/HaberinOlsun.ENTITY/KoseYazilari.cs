namespace HaberinOlsun.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KoseYazilari")]
    public partial class KoseYazilari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KoseYazilari()
        {
            Yorum = new HashSet<Yorum>();
        }

        [Key]
        public int YaziId { get; set; }

        public DateTime? YaziTarih { get; set; }

        public int YazarId { get; set; }

        [Required]
        [StringLength(250)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        public virtual Yazar Yazar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }
    }
}
