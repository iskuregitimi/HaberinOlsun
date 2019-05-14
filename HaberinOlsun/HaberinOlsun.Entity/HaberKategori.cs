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
        public int HaberKategoriId { get; set; }

        public int HaberId { get; set; }

        public int KategoriId { get; set; }

        public virtual Haberler Haberler { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
