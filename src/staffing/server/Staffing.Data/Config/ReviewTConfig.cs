using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staffing.Models.Entities;

namespace Staffing.Data.Config;

public class ReviewTConfig : IEntityTypeConfiguration<ReviewT>
{
    public void Configure(EntityTypeBuilder<ReviewT> builder)
    {
        
    }
}