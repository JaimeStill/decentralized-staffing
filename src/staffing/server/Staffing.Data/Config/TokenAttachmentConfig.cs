using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class TokenAttachmentConfig : IEntityTypeConfiguration<TokenAttachment>
{
    public void Configure(EntityTypeBuilder<TokenAttachment> builder)
    {
        builder
            .HasOne(x => x.Token)
            .WithMany(x => x.Attachments)
            .HasForeignKey(x => x.TokenId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}