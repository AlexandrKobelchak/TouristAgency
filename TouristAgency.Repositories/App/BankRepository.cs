using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class BankRepository : DbRepository<Bank>, IBankRepository
    {
        public BankRepository(DbContext context) : base(context)
        {
        }
    }
}
