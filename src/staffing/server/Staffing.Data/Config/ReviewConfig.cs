using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ReviewConfig : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.ProcessId);

        builder
            .HasOne(x => x.Role)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}