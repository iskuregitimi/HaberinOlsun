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
        [Key]
        public int YaziId { get; set; }

        public int YazarId { get; set; }

        public string Ozet { get; set; }

        public string Detay { get; set; }

        public virtual Yazarlar Yazarlar { get; set; }
    }
}
