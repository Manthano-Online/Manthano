using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.CreatedById).IsRequired();
    }
}
