using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Models.sgp;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Infrastructure.Persistence
{
     public class PGSQLDbContextSeed
     {
          public static async Task SeedAsync(PgSqlDbContext context, ILogger<PGSQLDbContextSeed> logger)
          {
               if (!context.Propiedad!.Any())
               {
                    context.Propiedad!.AddRange(GetPreconfiguredPropiedad());
                    await context.SaveChangesAsync();
                    logger.LogInformation("Estamos insertando nuevos records al db {context}", typeof(PgSqlDbContext).Name);
               }

          }

          private static IEnumerable<Propiedad> GetPreconfiguredPropiedad()
          {
               return new List<Propiedad>
            {
                new Propiedad {CreatedBy = "Admin", Descripcion = "Departamento",Direccion="Santa Cruz La Guardia" },
                new Propiedad {CreatedBy = "Admin", Descripcion = "casa rodante", Direccion = "Santa Cruz Cotoca"  },
            };

          }


     }
}
