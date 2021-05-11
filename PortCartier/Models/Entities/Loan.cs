using PortCartier.Models.Common;
using System;

namespace PortCartier.Models.Entities
{
    public class Loan : AuditableEntity
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public Document Document { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime ExpectedReturnDate { get; set; }
    }
}