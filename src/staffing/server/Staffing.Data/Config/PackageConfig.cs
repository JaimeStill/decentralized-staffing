using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class PackageConfig : IEntityTypeConfiguration<Package>
{
    public void Configure(EntityTypeBuilder<Package> builder)
    {
        builder
            .HasOne(x => x.Workflow)
            .WithOne(x => x.Package)
            .HasForeignKey<Package>(x => x.WorkflowId)
            .IsRequired(false);
    }
}