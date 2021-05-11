using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Data.Configuration
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(model => model.Title).IsRequired().HasMaxLength(250);

            builder.Property(model => model.Author).HasMaxLength(250);

            builder.HasOne(model => model.Category).WithMany(model => model.Documents).HasForeignKey(model => model.CategoryId);

            builder.HasMany(model => model.DocumentGenres).WithOne(model => model.Document).HasForeignKey(model => model.DocumentId);
        }
    }
}