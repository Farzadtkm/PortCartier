using PortCartier.Models.Common;

namespace PortCartier.Models.Entities
{
    public class DocumentGenre : AuditableEntity
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }
        
        public Document Document { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}