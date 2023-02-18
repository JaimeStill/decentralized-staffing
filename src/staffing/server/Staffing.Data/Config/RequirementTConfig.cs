using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class RequirementTConfig : IEntityTypeConfiguration<RequirementT>
{
    public void Configure(EntityTypeBuilder<RequirementT> builder)
    {
        builder
            .HasOne(x => x.ProcessT)
            .WithMany(x => x.RequirementTs)
            .HasForeignKey(x => x.ProcessTId);
    }
}