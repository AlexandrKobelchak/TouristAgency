using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class TourTypeRepository : DbRepository<TourType>, ITourTypeRepository
    {
        public TourTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
