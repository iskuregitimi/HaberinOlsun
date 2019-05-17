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
            Comments = new HashSet<Comment>();
        }

        [Key]
        public int YaziId { get; set; }

        public int YazarId { get; set; }

        public string Ozet { get; set; }

        public string Detay { get; set; }

        public string ResimURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Yazarlar Yazarlar { get; set; }
    }
}
