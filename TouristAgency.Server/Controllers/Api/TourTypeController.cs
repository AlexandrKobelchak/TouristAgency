using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TourTypeController : ApiController<ITourTypeRepository, TourType>
    {
        public TourTypeController(TourTypeRepository repository) : base(repository)
        {

        }
    }
}
