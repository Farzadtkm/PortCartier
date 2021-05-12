using PortCartier.Models.Common;
using PortCartier.Models.Enums;

namespace PortCartier.Models.Entities
{
    public class Request : AuditableEntity
    {
        public int Id { get; set; }

        public RequestStatus Status { get; set; }

        public int DocumentId { get; set; }

        public Document Document { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}