using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class WorkflowConfig : IEntityTypeConfiguration<Workflow>
{
    public void Configure(EntityTypeBuilder<Workflow> builder)
    {
        builder
            .HasOne(x => x.Organization)
            .WithMany(x => x.Workflows)
            .HasForeignKey(x => x.OrganizationId);
    }
}