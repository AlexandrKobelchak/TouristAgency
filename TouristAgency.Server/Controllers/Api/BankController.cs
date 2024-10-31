using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : ApiController<IBankRepository, Bank>
    {
        public BankController(IBankRepository repository) : base(repository)
        {

        }
    }

}
