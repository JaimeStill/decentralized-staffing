using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ProcessTConfig : IEntityTypeConfiguration<ProcessT>
{
    public void Configure(EntityTypeBuilder<ProcessT> builder)
    {
        builder
            .HasOne(x => x.Role)
            .WithMany(x => x.ProcessTs)
            .HasForeignKey(x => x.RoleId);
    }
}