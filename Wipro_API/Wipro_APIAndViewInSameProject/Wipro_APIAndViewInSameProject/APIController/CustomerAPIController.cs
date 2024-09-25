using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_APIAndViewInSameProject.Models;
using Wipro_APIAndViewInSameProject.Repository;

namespace Wipro_APIAndViewInSameProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerAPIController(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        [HttpPost("CreateCustomer")]

        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(this.customerRepository.CreateCustomer(customer));
        }

        [HttpGet("CustomerList")]

        public ActionResult GetCustomerList()
        {
            return Ok(this.customerRepository.GetCustomers());
        }

        [HttpPost("DeleteCustomer")]

        public ActionResult DeleteCustomer(Customer customer)
        {
            return Ok(this.customerRepository.DeleteCustomer(customer));
        }

        [HttpPost("UpdateCustomer")]

        public ActionResult UpdateCustomer(Customer customer)
        {
            return Ok(this.customerRepository.UpdateCustomer(customer));
        }

        [HttpPost("SearchCustomerByID")]

        public ActionResult SearchCustomer(int id)
        {
            return Ok(this.customerRepository.SearchCustomer(id));
        }



    }
}
