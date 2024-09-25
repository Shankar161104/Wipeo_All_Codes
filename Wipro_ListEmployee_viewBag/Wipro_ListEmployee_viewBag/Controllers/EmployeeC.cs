using Microsoft.AspNetCore.Mvc;
using Wipro_ListEmployee_viewBag.Models;

namespace Wipro_ListEmployee_viewBag.Controllers
{
    public class EmployeeC : Controller
    {
        public ActionResult Index()
        {
            Employee objEmployee = new Employee() 
            {
               EmpID=1,EmpName="Shankar",EmpSalary=30000
            };


            ViewBag.EmployeeID = objEmployee.EmpID;
            ViewBag.EmpName = objEmployee.EmpName;
            ViewBag.EmpSalary = objEmployee.EmpSalary;
            return View();
        }
    }
}
