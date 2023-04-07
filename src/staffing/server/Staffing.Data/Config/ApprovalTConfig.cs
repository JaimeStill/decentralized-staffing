using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;
public class ApprovalTConfig : IEntityTypeConfiguration<ApprovalT>
{
    public void Configure(EntityTypeBuilder<ApprovalT> builder)
    {
        builder
            .HasOne(x => x.ProcessT)
            .WithOne(x => x.ApprovalT)
            .HasForeignKey<ApprovalT>(x => x.ProcessTId);
    }
}