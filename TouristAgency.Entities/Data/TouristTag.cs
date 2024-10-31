using TouristAgency.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Entities
{
    [Table("tags")]
    public class TouristTag : DbEntity
    {
        [Column("firstName")]
        [MaxLength(64)]
        [Required]
        public string TagName { get; set; }
        public List<TouristProfileTag> ProfileTouristTag { get; set; }
        public List<TouristProfile> TouristProfiles { get; set; }
    }
}
