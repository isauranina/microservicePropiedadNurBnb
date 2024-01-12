
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Models.sgp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Infrastructure.Persistence
{
        public class PGSQLDbContext : DbContext
    {
       
        public PGSQLDbContext(DbContextOptions<PGSQLDbContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=db_nur;Username=postgres;Password=Clave**");


          public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
          {
               foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
               {
                    switch (entry.State)
                    {
                         case EntityState.Added:
                              entry.Entity.CreatedDate = DateTime.Now;
                              entry.Entity.CreatedBy = "system";
                              break;

                         case EntityState.Modified:
                              entry.Entity.LastModifiedDate = DateTime.Now;
                              entry.Entity.LastModifiedBy = "system";
                              break;
                    }
               }

               return base.SaveChangesAsync(cancellationToken);
          }
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
