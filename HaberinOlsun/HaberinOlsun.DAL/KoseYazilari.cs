namespace HaberinOlsun.DAL
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
        public int YaziID { get; set; }

        public int YazarID { get; set; }

        [Required]
        [StringLength(250)]
        public string Ozet { get; set; }

        [Required]
        public string Detay { get; set; }

        public virtual Yazarlar Yazarlar { get; set; }
    }
}
