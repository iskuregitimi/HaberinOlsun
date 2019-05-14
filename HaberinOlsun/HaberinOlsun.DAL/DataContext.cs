namespace HaberinOlsun.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext1")
        {
        }

        public virtual DbSet<Gundem> Gundem { get; set; }
        public virtual DbSet<Haberler> Haberler { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilari { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haberler>()
                .Property(e => e.Ozet)
                .IsFixedLength();

            modelBuilder.Entity<Haberler>()
                .Property(e => e.Kaynak)
                .IsFixedLength();

            modelBuilder.Entity<Haberler>()
                .Property(e => e.ResimURL)
                .IsFixedLength();

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Gundem)
                .WithRequired(e => e.Haberler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Kategori)
                .WithMany(e => e.Haberler)
                .Map(m => m.ToTable("HaberKategori").MapLeftKey("HaberID").MapRightKey("KategoriID"));

            modelBuilder.Entity<Kategori>()
                .Property(e => e.Adi)
                .IsFixedLength();

            modelBuilder.Entity<KoseYazilari>()
                .Property(e => e.Ozet)
                .IsFixedLength();

            modelBuilder.Entity<Yazarlar>()
                .Property(e => e.AdiSoyadi)
                .IsFixedLength();

            modelBuilder.Entity<Yazarlar>()
                .Property(e => e.ResimURL)
                .IsFixedLength();

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilari)
                .WithRequired(e => e.Yazarlar)
                .WillCascadeOnDelete(false);
        }
    }
}
