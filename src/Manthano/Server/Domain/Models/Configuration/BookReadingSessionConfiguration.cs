using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BookReadingSessionConfiguration : IEntityTypeConfiguration<BookReadingSession>
{
    public void Configure(EntityTypeBuilder<BookReadingSession> builder)
    {
        builder.Property(x => x.ReadOn).IsRequired();
        builder.Property(x => x.StartPage).IsRequired();
        builder.Property(x => x.EndPage).IsRequired();
        builder.Property(x => x.Note).HasMaxLength(ushort.MaxValue);

        builder.HasOne(brs => brs.BookReadThrough).WithMany(u => u.BookReadingSessions).HasForeignKey(brs => brs.BookReadThroughId);
    }
}
