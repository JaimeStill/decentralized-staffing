using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ReviewTConfig : IEntityTypeConfiguration<ReviewT>
{
    public void Configure(EntityTypeBuilder<ReviewT> builder)
    {
        builder
            .HasOne(x => x.ProcessT)
            .WithMany(x => x.ReviewTs)
            .HasForeignKey(x => x.ProcessTId);

        builder
            .HasOne(x => x.Role)
            .WithMany(x => x.ReviewTs)
            .HasForeignKey(x => x.RoleId);        
    }
}