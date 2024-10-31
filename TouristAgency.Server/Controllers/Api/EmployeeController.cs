using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ApiController<IEmployeeRepository, Employee>
    {
        public EmployeeController(IEmployeeRepository repository) : base(repository)
        {

        }
    }

}
