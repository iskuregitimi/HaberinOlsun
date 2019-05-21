namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HaberKategori")]
    public partial class HaberKategori
    {
        public int ID { get; set; }

        public int? KategoriID { get; set; }

        public int? HaberID { get; set; }

        public virtual Haber Haber { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
