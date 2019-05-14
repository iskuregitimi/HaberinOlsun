namespace Haberci.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Gundem> Gundem { get; set; }
        public virtual DbSet<Haberler> Haberler { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilari { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
