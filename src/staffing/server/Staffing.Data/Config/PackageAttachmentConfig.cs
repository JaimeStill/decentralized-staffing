using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class PackageAttachmentConfig : IEntityTypeConfiguration<PackageAttachment>
{
    public void Configure(EntityTypeBuilder<PackageAttachment> builder)
    {
        builder
            .HasOne(x => x.Package)
            .WithMany(x => x.Attachments)
            .HasForeignKey(x => x.PackageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}