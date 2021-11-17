using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BookReadThroughConfiguration : IEntityTypeConfiguration<BookReadThrough>
{
    public void Configure(EntityTypeBuilder<BookReadThrough> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BookId).IsRequired();
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.Review).HasMaxLength(2 * ushort.MaxValue);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);

        builder.HasOne(br => br.Book).WithMany(b => b.BookReadThroughs).HasForeignKey(br => br.BookId);
        builder.HasOne(br => br.User).WithMany(u => u.BookReadThroughs).HasForeignKey(br => br.UserId);
    }
}
