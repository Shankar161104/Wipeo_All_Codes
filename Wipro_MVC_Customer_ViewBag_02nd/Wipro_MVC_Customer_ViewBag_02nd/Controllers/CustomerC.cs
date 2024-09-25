using Microsoft.AspNetCore.Mvc;
using Wipro_MVC_Customer_ViewBag_02nd.Models;

namespace Wipro_MVC_Customer_ViewBag_02nd.Controllers
{
    public class CustomerC : Controller
    {
        public IActionResult Index()
        {
            List<Customer> lstCustomer = new List<Customer>();
            Customer objCustomer = new Customer();
            objCustomer.StudentID = 1;
            objCustomer.StudentName = "Shankar";
            objCustomer.StudentEmail = "shankarrentikota6@gmail.com";
            lstCustomer.Add(objCustomer);

            Customer objCustomer1 = new Customer();
            objCustomer1.StudentID = 2;
            objCustomer1.StudentName = "Dattu";
            objCustomer1.StudentEmail = "AVKDattu@gmail.com";
            lstCustomer.Add(objCustomer1);





            ViewBag.LstCustomer = lstCustomer;


            return View();
        }
    }
}
