namespace HaberinOlsun.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HaberKategori")]
    public partial class HaberKategori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HaberID { get; set; }

        public int KategoriID { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Haberler Haberler { get; set; }
    }
}
