using CleanArchitecture.Identity.Configurations;
using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace CleanArchitecture.Identity
{
    public class CleanArchitectureIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public CleanArchitectureIdentityDbContext(DbContextOptions<CleanArchitectureIdentityDbContext> options) : base(options)
        {
        }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               optionsBuilder.UseSqlServer(@"Server=(localhost);Database=Security;Persist Security Info=True;User ID=sa;Password=123456Zxcv;");
          }

          protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }

    }
}
