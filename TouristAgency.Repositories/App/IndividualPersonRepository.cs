using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class IndividualPersonRepository : DbRepository<IndividualPerson>, IIndividualPersonRepository
    {
        public IndividualPersonRepository(DbContext context) : base(context)
        {
        }
    }
}
