using Microsoft.AspNetCore.Mvc;
using Wipro_StronglyTyped_Student_02nd.Models;

namespace Wipro_StronglyTyped_Student_02nd.Controllers
{
    public class StudentC : Controller
    {
        public IActionResult Index()
        {
            List<Student> lstStudent = new List<Student>();
            Student objStudent = new Student() 
            {
               StudentID=1,StudentName="Shankar",StudentGender="Male",StudentSection="A",StudentBranch="Mech"
            };
            lstStudent.Add(objStudent);

            Student objStudent1 = new Student()
            {
                StudentID = 2,
                StudentName = "Dattu",
                StudentGender = "Male",
                StudentSection = "A",
                StudentBranch = "Civil"
            };
            lstStudent.Add(objStudent1);



            return View(lstStudent);
        }
    }
}
