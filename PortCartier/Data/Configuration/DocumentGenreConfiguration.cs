using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Data.Configuration
{
    public class DocumentGenreConfiguration : IEntityTypeConfiguration<DocumentGenre>
    {
        public void Configure(EntityTypeBuilder<DocumentGenre> builder)
        {
            builder.HasOne(model => model.Document).WithMany(model => model.DocumentGenres).HasForeignKey(model => model.DocumentId);

            builder.HasOne(model => model.Genre).WithMany(model => model.DocumentGenres).HasForeignKey(model => model.GenreId);
        }
    }
}