using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using CleanArchitecture.Domain.Models.sgp;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories.sgp
{
     public class PropiedadRepository :RepositoryBasePgsql <Propiedad>, IPropiedadRepository
     {
          public PropiedadRepository(PgSqlDbContext context) : base(context)
          { }

          public async Task<Propiedad> GetPropiedadByCiudad(long ciudadId)
          {
               return await _context.Propiedad!.Where(o => o.CiudadId == ciudadId).FirstOrDefaultAsync();
          }

          public async Task<IEnumerable<Propiedad>> GetPropiedadVerificado()
          {
               return await _context.Propiedad!.Where(v => v.esverificado).ToListAsync();
          }
     }
}
