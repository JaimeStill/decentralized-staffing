using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Enterprise.Models.Entities;

namespace Enterprise.Data.Config;

public class OrganizationUserConfig : IEntityTypeConfiguration<OrganizationUser>
{
    public void Configure(EntityTypeBuilder<OrganizationUser> builder)
    {
        builder
            .HasOne(x => x.Organization)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.OrganizationId);

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Organizations)
            .HasForeignKey(x => x.UserId);
    }
}