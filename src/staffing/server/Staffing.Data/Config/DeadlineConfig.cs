using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class DeadlineConfig : IEntityTypeConfiguration<Deadline>
{
    public void Configure(EntityTypeBuilder<Deadline> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithOne(x => x.Deadline)
            .HasForeignKey<Deadline>(x => x.ProcessId);        
    }
}