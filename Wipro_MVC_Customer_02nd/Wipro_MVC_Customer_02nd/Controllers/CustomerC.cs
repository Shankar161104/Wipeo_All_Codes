using Microsoft.AspNetCore.Mvc;
using Wipro_MVC_Customer_02nd.Models;

namespace Wipro_MVC_Customer_02nd.Controllers
{
    public class CustomerC : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Customer objCustomer = new Customer();
            objCustomer.CustomerID = 1;
            objCustomer.CustomerName = "Shankar";
            objCustomer.CustomerGender = "Male";
            objCustomer.CustomerEmail = "shankarrentikota6@gmail.com";
            objCustomer.CustomerAddress = "Vizianagaram";
            objCustomer.CustomerContact = 7893668421L;
            objCustomer.CustomerAge = 22;

            ViewData["Customer"] = objCustomer;
            return View();
            
        }
    }
}
