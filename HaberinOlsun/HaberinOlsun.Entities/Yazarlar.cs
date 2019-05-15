namespace HaberinOlsun.Entities
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
            KoseYazilaris = new HashSet<KoseYazilari>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YazarId { get; set; }

        [Required]
        public string AdiSoyadi { get; set; }

        [Required]
        [StringLength(250)]
        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KoseYazilari> KoseYazilaris { get; set; }
    }
}
