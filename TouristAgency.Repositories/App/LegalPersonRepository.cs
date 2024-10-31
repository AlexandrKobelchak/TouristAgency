using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class LegalPersonRepository : DbRepository<LegalPerson>, ILegalPersonRepository
    {
        public LegalPersonRepository(DbContext context) : base(context)
        {
        }
    }
}
