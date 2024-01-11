using CleanArchitecture.Domain.Models.sgp;


namespace CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp
{
     public interface IPropiedadRepository : IAsyncRepository<Propiedad>
     {
          Task<Propiedad> GetPropiedadByCiudad(long ciudadId);
          Task<IEnumerable<Propiedad>> GetPropiedadVerificado();
     }
}
