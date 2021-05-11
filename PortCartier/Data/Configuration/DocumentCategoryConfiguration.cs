using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Data.Configuration
{
    public class DocumentCategoryConfiguration : IEntityTypeConfiguration<DocumentCategory>
    {
        public void Configure(EntityTypeBuilder<DocumentCategory> builder)
        {
            builder.Property(f => f.Title).IsRequired().HasMaxLength(250);

            builder.HasMany(f => f.Documents).WithOne(f => f.Category).HasForeignKey(f => f.CategoryId);
        }
    }
}