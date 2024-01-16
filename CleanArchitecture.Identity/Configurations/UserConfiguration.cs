using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "088d5455-20d8-46b2-8697-c5cd129f13fd",
                        Email = "admin@locahost.com",
                        NormalizedEmail = "admin@locahost.com",
                        Nombre = "Isaura",
                        Apellidos = "Nina",
                        UserName = "Isa",
                        NormalizedUserName = "inina",
                        PasswordHash = hasher.HashPassword(null, "Clave**123"),
                        EmailConfirmed = true,
                    },
                    new ApplicationUser
                    {
                        Id = "451ce67b-a662-46fa-9c64-d672ac62cd2d",
                        Email = "juanperez@locahost.com",
                        NormalizedEmail = "juanperez@locahost.com",
                        Nombre = "Juan",
                        Apellidos = "Perez",
                        UserName = "juanperez",
                        NormalizedUserName = "juanperez",
                        PasswordHash = hasher.HashPassword(null, "Clave**123"),
                        EmailConfirmed = true,
                    }

                );


        }
    }
}
