using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortCartier.Models.Entities;

namespace PortCartier.Infrastructure.Persistence.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.Property(model => model.UserId).IsRequired();

            builder.HasOne(model => model.User).WithMany(model => model.Loans).HasForeignKey(model => model.UserId);
        }
    }
}