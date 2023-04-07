using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;
public class ApprovalConfig : IEntityTypeConfiguration<Approval>
{
    public void Configure(EntityTypeBuilder<Approval> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithOne(x => x.Approval)
            .HasForeignKey<Approval>(x => x.ProcessId);
    }
}