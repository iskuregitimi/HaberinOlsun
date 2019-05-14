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

        public virtual DbSet<Haberler> Haberlers { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KoseYazilari> KoseYazilaris { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Haberler>()
                .HasMany(e => e.Kategoris)
                .WithMany(e => e.Haberlers)
                .Map(m => m.ToTable("HaberKategori").MapLeftKey("HaberId").MapRightKey("KategoriId"));
        }
    }
}
