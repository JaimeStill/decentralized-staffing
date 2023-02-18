using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ProcessConfig : IEntityTypeConfiguration<Process>
{
    public void Configure(EntityTypeBuilder<Process> builder)
    {
        builder
            .HasOne(x => x.Role)
            .WithMany(x => x.Processes)
            .HasForeignKey(x => x.RoleId);

        builder
            .HasOne(x => x.Workflow)
            .WithMany(x => x.Processes)
            .HasForeignKey(x => x.WorkflowId);
    }
}