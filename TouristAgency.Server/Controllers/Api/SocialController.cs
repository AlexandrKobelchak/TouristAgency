using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialController : ApiController<ISocialNetworkRepository, SocialNetwork>
    {
        public SocialController(ISocialNetworkRepository repository) : base(repository)
        {

        }
    }
}
