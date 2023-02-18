using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class DeadlineTConfig : IEntityTypeConfiguration<DeadlineT>
{
    public void Configure(EntityTypeBuilder<DeadlineT> builder)
    {
        builder
            .HasOne(x => x.ProcessT)
            .WithOne(x => x.DeadlineT)
            .HasForeignKey<DeadlineT>(x => x.ProcessTId);
    }
}