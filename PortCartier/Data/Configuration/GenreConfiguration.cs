using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Data.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(model => model.Title).IsRequired().HasMaxLength(250);

            builder.HasMany(model => model.DocumentGenres).WithOne(model => model.Genre).HasForeignKey(model => model.GenreId);
        }
    }
}