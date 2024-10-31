using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TourController : ApiController<ITourRepository, Tour>
    {
        public TourController(ITourRepository repository) : base(repository)
        {

        }
    }
}
