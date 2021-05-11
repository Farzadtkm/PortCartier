using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Infrastructure.Persistence.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(model => model.UserId).IsRequired();

            builder.HasOne(model => model.User).WithMany(model => model.Requests).HasForeignKey(model => model.UserId);
        }
    }
}