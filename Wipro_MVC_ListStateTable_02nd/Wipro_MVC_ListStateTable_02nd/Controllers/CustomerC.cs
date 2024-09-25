using Microsoft.AspNetCore.Mvc;
using Wipro_MVC_ListStateTable_02nd.Models;

namespace Wipro_MVC_ListStateTable_02nd.Controllers
{
    public class CustomerC : Controller
    {
        public ActionResult Index()
        {
            List<Customer> lstCustomer = new List<Customer>();
            Customer objCustomer = new Customer();
            objCustomer.CustomerID = 1;
            objCustomer.CustomerName = "Shankar";
            objCustomer.CustomerCity = "Vizianagaram";
            objCustomer.CustomerAddress = "Cantonment";
            lstCustomer.Add(objCustomer);

            Customer objCustomer1 = new Customer();
            objCustomer1.CustomerID = 2;
            objCustomer1.CustomerName = "Udayasree";
            objCustomer1.CustomerCity = "Hyderabad";
            objCustomer1.CustomerAddress = "KPHB";
            lstCustomer.Add(objCustomer1);

            Customer objCustomer2 = new Customer();
            objCustomer2.CustomerID = 3;
            objCustomer2.CustomerName = "Durga Satya";
            objCustomer2.CustomerCity = "Tanuku";
            objCustomer2.CustomerAddress = "Tanuku";
            lstCustomer.Add(objCustomer2);




            ViewData["Customer"] = lstCustomer;
            return View();
        }
    }
}
