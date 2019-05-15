namespace HaberinOlsun.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gundem")]
    public partial class Gundem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HaberID { get; set; }

        public int Sira { get; set; }

        public virtual Haberler Haberler { get; set; }
    }
}
