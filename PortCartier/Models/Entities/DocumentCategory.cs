using PortCartier.Models.Common;
using System.Collections.Generic;

namespace PortCartier.Models.Entities
{
    public class DocumentCategory : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual List<Document> Documents { get; set; }
    }
}