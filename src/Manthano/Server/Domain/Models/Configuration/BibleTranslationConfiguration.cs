using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BibleTranslationConfiguration : IEntityTypeConfiguration<BibleTranslation>
{
    public void Configure(EntityTypeBuilder<BibleTranslation> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
        builder.Property(x => x.Language).IsRequired().HasMaxLength(255);
        builder.Property(x => x.AddedBy).IsRequired();
        builder.Property(x => x.VerseCountingType).IsRequired();

        builder.HasOne(bt => bt.User).WithMany(u => u.BibleTranslations).HasForeignKey(bt => bt.AddedBy);
    }
}
