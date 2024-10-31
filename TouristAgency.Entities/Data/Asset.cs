using TouristAgency.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TouristAgency.Entities
{
    public class Asset:IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [Column("fileName")]
        [MaxLength(260)]
        public required string FileName { get; set; }

        [Column("original")]
        [MaxLength(260)]
        public required string OriginalFileName { get; set; }

        [Column("mime")]
        [MaxLength(64)]
        public required string MimeType { get; set; }
        
        [Column("ext")]
        [MaxLength(32)]
        public required string FileExtention { get; set; }
    }
}
