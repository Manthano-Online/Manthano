using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manthano.Domain.Models.Configuration;

public class GoalDetailsConfiguration : IEntityTypeConfiguration<GoalDetails>
{
    public void Configure(EntityTypeBuilder<GoalDetails> builder)
    {
        builder.HasNoKey();
    }
}
