using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class AttachmentConfig : IEntityTypeConfiguration<Attachment>
{
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder
            .HasDiscriminator(x => x.Type)
            .HasValue<Attachment>("attachment")
            .HasValue<PackageAttachment>("package")
            .HasValue<ProcessAttachment>("process")
            .HasValue<TokenAttachment>("token");
    }
}