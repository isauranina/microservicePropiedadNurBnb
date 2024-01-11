
using CleanArchitecture.Domain.Models.Propiedad;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Infrastructure.Persistence
{
        public class PGSQLDbContext : DbContext
    {
        public PGSQLDbContext() { }
        protected readonly IConfiguration Configuration;
        public PGSQLDbContext(DbContextOptions<PGSQLDbContext> options) : base(options)
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=db_nur;Username=postgres;Password=Clave**");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        // public DbSet<Servicio>? Servicios => Set<Servicio>();
        public DbSet<Servicio>? Servicios { get; set; }
          public DbSet<Pais>? Pais { get; set; }
          public DbSet<TipoEstado>? TipoEstado{ get; set; }       
          public DbSet<TipoPropiedad>? TipoPropidad { get; set; }
          public DbSet<Ciudad>? Ciudad { get; set; }
          public DbSet<Agenda>? Agenda { get; set; }
          public DbSet<DetalleServicio>? DetalleServicio { get; set; }
          public DbSet<Propiedad>? Propiedad { get; set; }
          public DbSet<ReglasCasa>? ReglasCasa { get; set; }

     }
}
