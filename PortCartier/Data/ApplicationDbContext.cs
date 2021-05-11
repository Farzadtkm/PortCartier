using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortCartier.Core.Interfaces;
using PortCartier.Models.Common;
using PortCartier.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PortCartier.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
                                    ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<Document> Documents { get; set; }

        public DbSet<DocumentCategory> DocumentCategories { get; set; }

        public DbSet<DocumentGenre> DocumentGenres { get; set; }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<Request> Requests { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:

                        entry.Entity.CreatedBy = _currentUserService.UserId;

                        entry.Entity.Created = DateTime.Now;

                        break;

                    case EntityState.Modified:

                        entry.Entity.LastModifiedBy = _currentUserService.UserId;

                        entry.Entity.LastModified = DateTime.Now;

                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<PortCartier.Models.Entities.Genre> Genre { get; set; }
    }
}