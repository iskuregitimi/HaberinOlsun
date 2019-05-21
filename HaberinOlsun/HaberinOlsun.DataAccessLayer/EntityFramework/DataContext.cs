namespace HaberinOlsun.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HaberinOlsun.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Gundem> Gundem { get; set; }
        public virtual DbSet<Haber> Haber { get; set; }
        public virtual DbSet<HaberKategori> HaberKategori { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilari { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KoseYazilari>()
                .HasMany(e => e.Yorum)
                .WithOptional(e => e.KoseYazilari)
                .HasForeignKey(e => e.YaziID);

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilari)
                .WithOptional(e => e.Yazarlar)
                .HasForeignKey(e => e.YazarID);
        }
    }
}
