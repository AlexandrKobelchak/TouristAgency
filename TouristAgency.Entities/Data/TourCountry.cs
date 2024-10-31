using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Entities
{
    [Table("tours_countries")]
    public class TourCountry
    {
        [Column("countryId")]
        public Guid CountryId { get; set; }
        public required Country Country { get; set; }

        [Column("tourId")]
        public Guid TourId { get; set; }
        public required Tour Tour { get; set; }
    }
}
