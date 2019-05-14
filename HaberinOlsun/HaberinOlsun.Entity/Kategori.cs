namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategori")]
    public partial class Kategori
    {
        public int KategoriId { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(100)]
        public string Aciklama { get; set; }
    }
}
