using Microsoft.AspNetCore.Mvc;
using Wipro_StronglyTyped_02nd.Models;

namespace Wipro_StronglyTyped_02nd.Controllers
{
    public class CustomerC : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerDetails()
        {
            List<Customer> lstCustomer = new List<Customer>();
            Customer objCustomer = new Customer()
            {
                CustomerID = 101,
                CustomerName = "Dattu",
                CustomerGender = "Male",
                CustomerContact = 7345345342L

            };
            lstCustomer.Add(objCustomer);

            Customer objCustomer1 = new Customer()
            {
                CustomerID = 101,
                CustomerName = "Dattu",
                CustomerGender = "Male",
                CustomerContact = 7345345342L

            };
            lstCustomer.Add(objCustomer1);



            return View(lstCustomer);
        }
    }
}
