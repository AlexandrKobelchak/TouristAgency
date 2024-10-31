using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Entities
{
    [Table("tours_ tourTypes")]
    public class TourTourType
    {
        [Column("tourTypeId")]
        public Guid TourTypeId { get; set; }
        public required TourType TourType { get; set; }

        [Column("tourId")]
        public Guid TourId { get; set; }
        public required Tour Tour { get; set; }
    }
}