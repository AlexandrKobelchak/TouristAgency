using TouristAgency.Entities;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Repositories.Generic;

namespace TouristAgency.Repositories
{
    public class TouristPhoneRepository : DbRepository<TouristPhone>, ITouristPhoneRepository
    {
        public TouristPhoneRepository(DbContext context) : base(context)
        {
        }
    }
}
