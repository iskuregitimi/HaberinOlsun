namespace HaberinOlsun.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HaberinOlsun.Entities;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Haberler> Haberlers { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilaris { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }
        public virtual DbSet<Gundem> Gundems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haberler>()
                .HasOptional(e => e.Gundem)
                .WithRequired(e => e.Haberler);

            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Kategoris)
                .WithMany(e => e.Haberlers)
                .Map(m => m.ToTable("HaberKategori").MapLeftKey("HaberId").MapRightKey("KategoriId"));

            modelBuilder.Entity<Yazarlar>()
                .HasMany(e => e.KoseYazilaris)
                .WithRequired(e => e.Yazarlar)
                .WillCascadeOnDelete(false);
        }
    }
}
