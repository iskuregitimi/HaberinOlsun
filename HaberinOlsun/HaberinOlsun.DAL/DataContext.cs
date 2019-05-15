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

        public virtual DbSet<Haber> Habers { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilaris { get; set; }
        public virtual DbSet<Yazar> Yazars { get; set; }
        public virtual DbSet<Gundem> Gundems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Gundems)
                .WithRequired(e => e.Haber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Kategoris)
                .WithMany(e => e.Habers)
                .Map(m => m.ToTable("HaberKategori").MapLeftKey("HaberId").MapRightKey("KategoriId"));

            modelBuilder.Entity<Yazar>()
                .HasMany(e => e.KoseYazilaris)
                .WithRequired(e => e.Yazar)
                .WillCascadeOnDelete(false);
        }
    }
}
