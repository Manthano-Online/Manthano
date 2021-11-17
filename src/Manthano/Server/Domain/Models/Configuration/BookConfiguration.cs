using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
        builder.Property(x => x.StartPage).IsRequired();
        builder.Property(x => x.EndPage).IsRequired();
        builder.Property(x => x.Author).IsRequired();

        builder.HasOne(b => b.Creator).WithMany(u => u.Books).HasForeignKey(b => b.CreatedById);
    }
}
