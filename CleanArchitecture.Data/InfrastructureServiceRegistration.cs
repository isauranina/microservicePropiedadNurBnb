using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using CleanArchitecture.Application.Models;
using CleanArchitecture.Infrastructure.Email;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Infrastructure.Repositories.sgp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
     public static class InfrastructureServiceRegistration
     {
          public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
          {
               //services.AddMvc();
               //services.AddEntityFrameworkNpgsql().AddDbContext<PGSQLDbContext>(opt =>
               //    opt.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnectionString")));

               services.AddDbContext<PgSqlDbContext>(options =>
                   options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnectionString"))
               );

               //services.AddDbContext<StreamerDbContext>(options =>
               //    options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
               //);



               services.AddScoped<IUnitOfWork, UnitOfWork>();
               services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
               services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBasePgsql<>));

              // services.AddScoped<IVideoRepository, VideoRepository>();
               //services.AddScoped<IStreamerRepository, StreamerRepository>();
               services.AddScoped<IPropiedadRepository, PropiedadRepository>();

               services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
               services.AddTransient<IEmailService, EmailService>();

               return services;
          }

     }
}
