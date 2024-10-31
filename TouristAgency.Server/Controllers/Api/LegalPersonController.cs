using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LegalPersonController : ApiController<ILegalPersonRepository, LegalPerson>
    {
        public LegalPersonController(ILegalPersonRepository repository) : base(repository)
        {

        }
    }
}
