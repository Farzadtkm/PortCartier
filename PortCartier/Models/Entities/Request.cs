using PortCartier.Models.Common;

namespace PortCartier.Models.Entities
{
    public class Request : AuditableEntity
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public Document Document { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}