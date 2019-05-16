namespace HaberinOlsun.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gundem")]
    public partial class Gundem
    {
        public int GundemID { get; set; }

        public int HaberID { get; set; }

        public int Sira { get; set; }

        public virtual Haberler Haberler { get; set; }

        public virtual Haberler Haberler1 { get; set; }
    }
}
