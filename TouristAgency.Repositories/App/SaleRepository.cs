using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class SaleRepository : DbRepository<Sale>, ISaleRepository
    {
        public SaleRepository(DbContext context) : base(context)
        {
        }
    }
}
