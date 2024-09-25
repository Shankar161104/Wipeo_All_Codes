using Microsoft.AspNetCore.Mvc;
using Wipro_MVC_Student_ViewBag_02nd.Models;

namespace Wipro_MVC_Student_ViewBag_02nd.Controllers
{
    public class StudentC : Controller
    {
        public ActionResult Index()
        {
            Student objStudent = new Student();
            objStudent.StudentID = 1;
            objStudent.StudentName = "Shankar";
            objStudent.StudentBranch = "Mechanical";

            ViewBag.Student = objStudent;
            return View();
        }
    }
}
