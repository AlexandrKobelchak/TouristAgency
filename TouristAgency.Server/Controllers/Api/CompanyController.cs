using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ApiController<ICompanyRepository, Company>
    {
        public CompanyController(ICompanyRepository repository) : base(repository)
        {

        }
    }

}
