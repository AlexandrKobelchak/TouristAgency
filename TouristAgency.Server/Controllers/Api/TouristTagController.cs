using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TouristTagController : ApiController<ITouristTagRepository, TouristTag>
    {
        public TouristTagController(ITouristTagRepository repository) : base(repository)
        {

        }
    }
}
