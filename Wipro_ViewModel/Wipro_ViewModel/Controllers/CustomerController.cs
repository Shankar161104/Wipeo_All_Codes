using Microsoft.AspNetCore.Mvc;
using Wipro_ViewModel.Models;

namespace Wipro_ViewModel.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerC()
        {
            Customer objCustomer = new Customer() 
            {
              CustomerID=1,CustomerName="bhAAI",CustomerGender="Male",CustomerContact=78912536,CustomerEmail="bhaaai@gmail.com"
            };
            List<AddressCustomer> lstCustomer = new List<AddressCustomer>();

            AddressCustomer objAddressCustomer = new AddressCustomer() 
            {
               CustomerID=1,PinCode=234444,City="Hyderabad",State="Telangana",Country="Bharat"
            };
            lstCustomer.Add(objAddressCustomer);

            CustomerDetailsViewModel objCustDetails = new CustomerDetailsViewModel() 
            {
               Customer=objCustomer,LstCustomer=lstCustomer
            };
            return View(objCustDetails);


        }
    }
}
