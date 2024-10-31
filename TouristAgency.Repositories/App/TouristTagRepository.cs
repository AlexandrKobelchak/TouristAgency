using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class TouristTagRepository : DbRepository<TouristTag>, ITouristTagRepository
    {
        public TouristTagRepository(DbContext context) : base(context)
        {
        }
    }
}
