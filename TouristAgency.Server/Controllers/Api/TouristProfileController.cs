using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TouristProfileController : ApiController<ITouristProfileRepository, TouristProfile>
    {
        public TouristProfileController(ITouristProfileRepository repository) : base(repository)
        {
            
        }
    }
}
