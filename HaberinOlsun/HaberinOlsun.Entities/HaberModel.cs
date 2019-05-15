namespace HaberinOlsun.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HaberModel : DbContext
    {
        public HaberModel()
            : base("name=HaberModel1")
        {
        }

        public virtual DbSet<Gundem> Gundems { get; set; }
        public virtual DbSet<HaberKategori> HaberKategoris { get; set; }
        public virtual DbSet<Haberler> Haberlers { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilaris { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<HaberKategori>()
                .HasOptional(e => e.Haberler)
                .WithRequired(e => e.HaberKategori);

            modelBuilder.Entity<Haberler>()
                .Property(e => e.Baslik)
                .IsUnicode(false);

            modelBuilder.Entity<Haberler>()
                .Property(e => e.Ozet)
                .IsUnicode(false);

            modelBuilder.Entity<Haberler>()
                .Property(e => e.Detay)
                .IsUnicode(false);

            modelBuilder.Entity<Haberler>()
                .Property(e => e.Kaynak)
                .IsUnicode(false);

            modelBuilder.Entity<Haberler>()
                .HasOptional(e => e.Gundem)
                .WithRequired(e => e.Haberler);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.Adi)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.HaberKategoris)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KoseYazilari>()
                .Property(e => e.Ozet)
                .IsUnicode(false);

            modelBuilder.Entity<KoseYazilari>()
                .Property(e => e.Detay)
                .IsUnicode(false);

            modelBuilder.Entity<Yazarlar>()
                .Property(e => e.AdiSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilaris)
                .WithRequired(e => e.Yazarlar)
                .WillCascadeOnDelete(false);
        }
    }
}
