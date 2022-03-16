

using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class ProjekatContext : DbContext 
    {
        public DbSet<Zona> Zone { get; set; }
        public DbSet<Linija> Linije { get; set; }
        public DbSet<Autobus> Autobusi { get; set; }
        public DbSet<AutobusLinija> AutobusiLinija { get; set;}

        public DbSet<Radnik> Radnici { get; set; }

        public DbSet<Karta> Karte { get; set; }

        public ProjekatContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutobusLinija>()
                .Property(p => p.DanVoznje)
                .HasColumnType("date");
        }
    }
}