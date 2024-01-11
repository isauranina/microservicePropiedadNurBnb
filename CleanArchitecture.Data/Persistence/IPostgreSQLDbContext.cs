using CleanArchitecture.Domain.Models.Propiedad;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public interface IPostgreSQLDbContext
    {
        DbSet<Servicio> Servicios { get; }
    }
}