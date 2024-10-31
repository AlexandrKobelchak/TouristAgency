using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndividualPersonController : ApiController<IIndividualPersonRepository, IndividualPerson>
    {
        public IndividualPersonController(IIndividualPersonRepository repository) : base(repository)
        {

        }
    }
}
