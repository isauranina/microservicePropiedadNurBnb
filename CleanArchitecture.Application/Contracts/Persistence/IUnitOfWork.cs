using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        //borrar
        //IStreamerRepository StreamerRepository { get; }
       // IVideoRepository VideoRepository { get; }
          //
        IPropiedadRepository PropiedadRepository { get; }
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

        Task<int> Complete();
    }
}
