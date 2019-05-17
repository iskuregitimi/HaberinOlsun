namespace HaberinOlsun.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        public int CommentID { get; set; }

        public int? YazıID { get; set; }

        public int? HaberID { get; set; }

        [Required]
        [StringLength(100)]
        public string Gönderen { get; set; }

        [Required]
        [StringLength(1000)]
        public string Yorum { get; set; }
    }
}
