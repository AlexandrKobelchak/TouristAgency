using TouristAgency.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Entities
{
    [Table("tours")]
    public class Tour: DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        [Required]
        public required string Name { get; set; }
        public List<TourTourType>? TourTourType { get; set; }
        public List<TourType>? TourTypes { get; set; }
        public List<TourCountry>? CountryTour { get; set; }
        public List<Country>? Countries { get; set; }
        public List<Sale>? Sales { get; set; }
    }
}
