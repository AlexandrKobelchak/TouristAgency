using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ApiController<ICountryRepository, Country>
    {
        public CountryController(ICountryRepository repository) : base(repository)
        {

        }
    }

}
