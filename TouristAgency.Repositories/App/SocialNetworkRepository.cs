using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class SocialNetworkRepository : DbRepository<SocialNetwork>, ISocialNetworkRepository
    {
        public SocialNetworkRepository(DbContext context) : base(context)
        {
        }
    }
}
