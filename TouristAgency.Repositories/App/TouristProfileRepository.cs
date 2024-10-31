using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class TouristProfileRepository : DbRepository<TouristProfile>, ITouristProfileRepository
    {
        public TouristProfileRepository(DbContext context) : base(context)
        {
        }
    }
}
