using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1425c889-1aa4-47be-88e7-f25f6d546d5a",
                    UserId = "088d5455-20d8-46b2-8697-c5cd129f13fd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "0a51514a-2e86-48be-99f9-76bbaaf2443e",
                    UserId = "451ce67b-a662-46fa-9c64-d672ac62cd2d"
                }

            );
        }
    }
}
