using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class TokenConfig : IEntityTypeConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
        builder
            .HasOne(x => x.Package)
            .WithOne(x => x.Token)
            .HasForeignKey<Token>(x => x.PackageId);

        builder
            .HasOne(x => x.Registration)
            .WithMany(x => x.Tokens)
            .HasForeignKey(x => x.RegistrationId);
    }
}