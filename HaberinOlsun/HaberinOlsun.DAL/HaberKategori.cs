namespace HaberinOlsun.DAL
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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HaberID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KategoriID { get; set; }

        public virtual Haberler Haberler { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Haberler Haberler1 { get; set; }

        public virtual Kategori Kategori1 { get; set; }
    }
}
