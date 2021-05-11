using PortCartier.Models.Common;
using System.Collections.Generic;

namespace PortCartier.Models.Entities
{
    public class Genre : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual List<DocumentGenre> DocumentGenres { get; set; }
    }
}