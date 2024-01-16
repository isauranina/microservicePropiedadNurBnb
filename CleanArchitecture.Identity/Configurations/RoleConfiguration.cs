using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                { 
                    Id = "1425c889-1aa4-47be-88e7-f25f6d546d5a",
                    Name = "Admin",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole
                {
                    Id = "0a51514a-2e86-48be-99f9-76bbaaf2443e",
                    Name = "Operador",
                    NormalizedName = "OPERADOR"
                }


            );
        }
    }
}
