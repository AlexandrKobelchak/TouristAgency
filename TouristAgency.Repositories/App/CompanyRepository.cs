using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class CompanyRepository : DbRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext context) : base(context)
        {
        }
    }
}
