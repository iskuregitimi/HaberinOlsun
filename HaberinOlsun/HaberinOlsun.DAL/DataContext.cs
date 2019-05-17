namespace HaberinOlsun.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HaberinOlsun.ENTITY;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Haber> Haber { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilari { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
        public virtual DbSet<Gundem> Gundem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Gundem)
                .WithRequired(e => e.Haber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Kategori)
                .WithMany(e => e.Haber)
                .Map(m => m.ToTable("HaberKategori").MapLeftKey("HaberId").MapRightKey("KategoriId"));

            modelBuilder.Entity<Yazar>()
                .HasMany(e => e.KoseYazilari)
                .WithRequired(e => e.Yazar)
                .WillCascadeOnDelete(false);
        }
    }
}
