using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wipro_First_Service.Controllers
{


    




    [Route("api/[controller]")]
    [ApiController]

    


    public class CustomerController : ControllerBase
    {


        [HttpGet("FetchCustomer")]
        public IActionResult Fetch()
        {
            return Ok("All Wipro Candidates wasting time succesfully");
        }
    }
}
