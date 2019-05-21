namespace HaberinOlsun.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gundem")]
    public partial class Gundem
    {
        public int ID { get; set; }

        public int? HaberID { get; set; }

        public int? Sira { get; set; }

        public virtual Haber Haber { get; set; }
    }
}
