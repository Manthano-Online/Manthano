using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class UserSettingsConfiguration : IEntityTypeConfiguration<UserSettings>
{
    public void Configure(EntityTypeBuilder<UserSettings> builder)
    {
        builder.Property(u => u.UserId).IsRequired();

        //builder.HasOne(u => u.AppUser).WithOne(u => u.UserSettings).HasForeignKey<UserSettings>(u => u.UserId);
    }
}
