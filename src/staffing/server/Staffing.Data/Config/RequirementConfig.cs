using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class RequirementConfig : IEntityTypeConfiguration<Requirement>
{
    public void Configure(EntityTypeBuilder<Requirement> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithMany(x => x.Requirements)
            .HasForeignKey(x => x.ProcessId);
    }
}