using Microsoft.AspNetCore.Mvc;
using TouristAgency.Entities;
using TouristAgency.Repositories;

namespace TouristAgency.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ApiController<ISaleRepository, Sale>
    {
        public SaleController(SaleRepository repository) : base(repository)
        {

        }
    }
}
