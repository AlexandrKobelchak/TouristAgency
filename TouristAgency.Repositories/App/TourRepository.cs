using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class TourRepository : DbRepository<Tour>, ITourRepository
    {
        public TourRepository(DbContext context) : base(context)
        {
        }
    }
}
