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

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Gundem> Gundems { get; set; }
        public virtual DbSet<HaberKategori> HaberKategoris { get; set; }
        public virtual DbSet<Haberler> Haberlers { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilaris { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Gundems)
                .WithRequired(e => e.Haberler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.HaberKategoris)
                .WithRequired(e => e.Haberler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.HaberKategoris)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilaris)
                .WithRequired(e => e.Yazarlar)
                .WillCascadeOnDelete(false);
        }
    }
}
