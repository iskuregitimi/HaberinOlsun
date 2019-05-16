namespace HaberinOlsun.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yazarlar")]
    public partial class Yazarlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yazarlar()
        {
            KoseYazilari = new HashSet<KoseYazilari>();
            KoseYazilari1 = new HashSet<KoseYazilari>();
        }

        [Key]
        public int YazarID { get; set; }

        [Required]
        [StringLength(100)]
        public string AdiSoyadi { get; set; }

        [Required]
        [StringLength(500)]
        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KoseYazilari> KoseYazilari { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KoseYazilari> KoseYazilari1 { get; set; }
    }
}
