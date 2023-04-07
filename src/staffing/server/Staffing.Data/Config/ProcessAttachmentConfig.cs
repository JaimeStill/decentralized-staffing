using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ProcessAttachmentConfig : IEntityTypeConfiguration<ProcessAttachment>
{
    public void Configure(EntityTypeBuilder<ProcessAttachment> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithMany(x => x.Attachments)
            .HasForeignKey(x => x.ProcessId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}