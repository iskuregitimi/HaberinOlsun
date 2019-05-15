namespace HaberinOlsun.DAL
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

        public virtual DbSet<HaberKategori> HaberKategori { get; set; }
        public virtual DbSet<Haberler> Haberler { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilari { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }
        public virtual DbSet<Gundem> Gundem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.HaberKategori)
                .WithRequired(e => e.Haberler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Gundem)
                .WithRequired(e => e.Haberler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.HaberKategori)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilari)
                .WithRequired(e => e.Yazarlar)
                .WillCascadeOnDelete(false);
        }
    }
}
