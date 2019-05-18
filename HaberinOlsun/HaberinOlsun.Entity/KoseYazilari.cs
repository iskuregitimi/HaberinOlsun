namespace HaberinOlsun.Entity
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
            Yorumlars = new HashSet<Yorumlar>();
        }

        [Key]
        public int YaziId { get; set; }

        public int YazarId { get; set; }

        [Required]
        [StringLength(100)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        public virtual Yazarlar Yazarlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
