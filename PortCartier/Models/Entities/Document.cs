using PortCartier.Models.Enums;
using PortCartier.Models.Common;
using System.Collections.Generic;

namespace PortCartier.Models.Entities
{
    public class Document : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string Author { get; set; }

        public int YearOfPublication { get; set; }

        public int CategoryId { get; set; }

        public DocumentCategory Category { get; set; }

        public DocumentType Type { get; set; }

        public List<DocumentGenre> DocumentGenres { get; set; }

        public string Description { get; set; }

        public bool ISBN { get; set; }
    }
}