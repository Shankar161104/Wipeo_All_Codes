using Microsoft.AspNetCore.Mvc;
using Wipro_StronglyTyped_02nd.Models;

namespace Wipro_StronglyTyped_02nd.Controllers
{
    public class EmployeeC : Controller
    {
        public IActionResult Index()
        {
            Employee objEmployee = new Employee() 
            {
              EmpID=1,EmpName="Shankar",EmpAddress="Hyderabad"
            };
            return View(objEmployee);
        }
    }
}
