using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BibleReadingSessionConfiguration : IEntityTypeConfiguration<BibleReadingSession>
{
    public void Configure(EntityTypeBuilder<BibleReadingSession> builder)
    {
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.ReadThroughId).IsRequired();
        builder.Property(x => x.StartChapterId).IsRequired();
        builder.Property(x => x.EndChapterId).IsRequired();
        builder.Property(x => x.Date).IsRequired();

        builder.HasOne(brs => brs.ReadThrough).WithMany(rt => rt.Sessions);
    }
}
