using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TouristPhoneController : ApiController<ITouristPhoneRepository, TouristPhone>
    {
        public TouristPhoneController(ITouristPhoneRepository repository) : base(repository)
        {

        }
    }
}
