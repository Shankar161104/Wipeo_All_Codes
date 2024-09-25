using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_CodeFirstApproach.Repository;
using Wipro_API_CodeFirstApproach.Model;
using Wipro_API_CodeFirstApproach.Entity_Framework;

namespace Wipro_API_CodeFirstApproach.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class CustomerController : ControllerBase

    {

        private readonly ICustomerService icustomerService;

        public CustomerController(ICustomerService _icustomerService)

        {

            icustomerService = _icustomerService;

        }

        [HttpPost("CreateCustomer")]

        public ActionResult CreateCustomer(Customer customer)

        {

            return Ok(icustomerService.CreateCustomer(customer));

        }

        [HttpGet("CustomerList")]

        public ActionResult GetCustomerList()

        {

            return Ok(icustomerService.GetCustomer());

        }

        [HttpGet("SearchCustomerById")]

        public ActionResult SearchCustomer(int customerId)

        {

            return Ok(icustomerService.SearchCustomer(customerId));

        }

        [HttpPut("UpdateCustomer")]

        public ActionResult UpdateCustomer(Customer customer)

        {

            return Ok(icustomerService.UpdateCustomer(customer));

        }

        [HttpDelete("DeleteCustomer")]

        public ActionResult DeleteCustomer(int customerId)

        {

            return Ok(icustomerService.DeleteCustomer(customerId));

        }

    }

}
