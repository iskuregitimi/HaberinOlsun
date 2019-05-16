namespace HaberinOlsun.DAL
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
        public virtual DbSet<HaberKategori> HaberKategori { get; set; }
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
                .HasForeignKey(e => e.HaberID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Gundem1)
                .WithRequired(e => e.Haberler1)
                .HasForeignKey(e => e.HaberID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.HaberKategori)
                .WithRequired(e => e.Haberler)
                .HasForeignKey(e => e.HaberID);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.HaberKategori1)
                .WithRequired(e => e.Haberler1)
                .HasForeignKey(e => e.HaberID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.Adi)
                .IsFixedLength();

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.HaberKategori)
                .WithRequired(e => e.Kategori)
                .HasForeignKey(e => e.KategoriID);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.HaberKategori1)
                .WithRequired(e => e.Kategori1)
                .HasForeignKey(e => e.KategoriID)
                .WillCascadeOnDelete(false);

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
                .HasForeignKey(e => e.YazarID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilari1)
                .WithRequired(e => e.Yazarlar1)
                .HasForeignKey(e => e.YazarID)
                .WillCascadeOnDelete(false);
        }
    }
}
