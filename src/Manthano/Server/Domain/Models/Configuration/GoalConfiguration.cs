using Manthano.Domain.Models.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class GoalConfiguration : IEntityTypeConfiguration<Goal>
{
    public void Configure(EntityTypeBuilder<Goal> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.CreatedById).IsRequired();
        builder.Property(x => x.StartDate).IsRequired();
        builder.Property(x => x.EndDate).IsRequired();
        builder.Property(x => x.GoalDetails).HasJsonConversion().HasDefaultValue(new GoalDetails());

        builder.HasOne(g => g.Church).WithMany(c => c.Goals).HasForeignKey(g => g.ChurchId);
        builder.HasOne(g => g.Group).WithMany(c => c.Goals).HasForeignKey(g => g.GroupId);
        builder.HasOne(g => g.Owner).WithMany(u => u.Goals).HasForeignKey(g => g.CreatedById);
    }
}
