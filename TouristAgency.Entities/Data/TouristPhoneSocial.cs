using TouristAgency.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouristAgency.Entities
{
    public class TouristPhoneSocial
    {
        public required TouristPhone TouristPhone { get; set; }
        public required SocialNetwork SocialNetwork { get; set; }

        public Guid PhoneId { get; set; }
        public Guid SocialId { get; set; }
    }
}
