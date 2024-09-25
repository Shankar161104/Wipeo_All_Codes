using Microsoft.AspNetCore.Mvc;
using Wipro_ViewModel.Models;

namespace Wipro_ViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee objEmployee = new Employee() 
            {
               EmpID=1,EmpName="Shankar",EmpGender="Male",EmpDept="Finance",EmpSal=123444,AddressId=101
            };

            Address objAddress = new Address() 
            {
               AddressId=101,Country="Bharat",state="Andhra Pradesh",City="Vizianagaram"
            };

            EmployeeDetailsViewModel objDetails = new EmployeeDetailsViewModel() 
            {
               PageTitle="ViewModel",PageHeader="ViewModel",Employee=objEmployee,Address=objAddress
            };





            return View(objDetails);
        }
    }
}
