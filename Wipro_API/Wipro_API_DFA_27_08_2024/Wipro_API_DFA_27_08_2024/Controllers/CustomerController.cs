using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_DFA_27_08_2024.Models;
using Wipro_API_DFA_27_08_2024.Repository;

namespace Wipro_API_DFA_27_08_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        [HttpPost("Create Customer")]
        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(customerRepository.CreateCustomer(customer));
        }

        [HttpGet("Show Customer list")]
        public ActionResult GetAllCustomers(Customer customer)
        {
            return Ok(customerRepository.GetAllCustomers());
        }

        [HttpGet("ShowCustomerByID")]

        public ActionResult SearchCustomer(int CustomerID)
        {
            return Ok(customerRepository.SearchCustomer(CustomerID));
        }


        [HttpDelete("DeleteCustomer")]
        public ActionResult DeleteCustomer(int customerId)
        {
            return Ok(customerRepository.DeleteCustomer(customerId));
        }



    }
}
