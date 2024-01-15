using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories.sgp;
using System.Collections;

namespace CleanArchitecture.Infrastructure.Repositories
{
     public class UnitOfWork : IUnitOfWork
     {
          private Hashtable _repositories;
          //private readonly StreamerDbContext _context;
          private readonly PgSqlDbContext _context;

          //private IVideoRepository _videoRepository;
          //private IStreamerRepository _streamerRepository;
          private IPropiedadRepository _propiedadRepository;


         // public IVideoRepository VideoRepository => _videoRepository ??= new VideoRepository(_context);

         // public IStreamerRepository StreamerRepository => _streamerRepository ??= new StreamerRepository(_context);
          public IPropiedadRepository   PropiedadRepository => _propiedadRepository ??= new PropiedadRepository(_context);

          public UnitOfWork(PgSqlDbContext context)
          {
               _context = context;
          }

          public PgSqlDbContext PgSqlDbContext => _context;

          public async Task<int> Complete()
          {
               try
               {
                    return await _context.SaveChangesAsync();
               }
               catch (Exception ex)
               {
                    throw new Exception("Err");
               }

          }



          public void Dispose()
          {
               _context.Dispose();
          }

          public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
          {
               if (_repositories == null)
               {
                    _repositories = new Hashtable();
               }

               var type = typeof(TEntity).Name;

               if (!_repositories.ContainsKey(type))
               {
                    var repositoryType = typeof(RepositoryBasePgsql<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                    _repositories.Add(type, repositoryInstance);
               }

               return (IAsyncRepository<TEntity>)_repositories[type];
          }


     }
}
