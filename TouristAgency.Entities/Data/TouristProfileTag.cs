using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Entities
{
    [Table("tourists_tags")]
    public class TouristProfileTag
    {
        [Column("touristId")]
        public Guid TouristId { get; set; }
        public required TouristProfile TouristProfile { get; set; }

        [Column("tagId")]
        public Guid TagId { get; set; }
        public required TouristTag TouristTag { get; set; }
    }
}
