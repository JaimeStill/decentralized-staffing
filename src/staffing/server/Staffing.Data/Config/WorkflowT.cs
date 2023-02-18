using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class WorkflowTConfig : IEntityTypeConfiguration<WorkflowT>
{
    public void Configure(EntityTypeBuilder<WorkflowT> builder)
    {
        
    }
}