using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class ChurchConfiguration : IEntityTypeConfiguration<Church>
{
    public void Configure(EntityTypeBuilder<Church> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.City).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Denomination).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Website).HasMaxLength(255);

        builder.ToTable("Churches");
        builder.HasMany(c => c.Members).WithOne(u => u.Church).HasForeignKey(u => u.ChurchId);
        builder.HasMany(c => c.Goals).WithOne(g => g.Church).HasForeignKey(g => g.ChurchId);
    }
}
