using Microsoft.AspNetCore.Mvc;

namespace Wipro_CourseList_02nd.Controllers
{
    public class Course : Controller
    {
        public IActionResult Index()
        {
            List<string> lstCourse = new List<string>();
            lstCourse.Add("BTech");
            lstCourse.Add("MBA");
            lstCourse.Add("MCA");
            lstCourse.Add("bhAAI");
            lstCourse.Add("MS");
            lstCourse.Add("Polytechnic");
            ViewData["Course"] = lstCourse;

            return View();
        }
    }
}
