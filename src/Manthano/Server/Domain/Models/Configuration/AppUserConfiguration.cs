using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(255);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(255);

        //builder.HasOne(x => x.UserSettings).WithOne(x => x.AppUser).HasForeignKey<UserSettings>(x => x.UserId);
    }
}
