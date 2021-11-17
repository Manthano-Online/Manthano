using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BibleReadThroughConfiguration : IEntityTypeConfiguration<BibleReadThrough>
{
    public void Configure(EntityTypeBuilder<BibleReadThrough> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.StartDate).IsRequired();
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.BibleTranslationId).IsRequired();

        builder.HasOne(rt => rt.BibleTranslation);
    }
}
