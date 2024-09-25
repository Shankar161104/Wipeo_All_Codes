using Microsoft.AspNetCore.Mvc;
using Wipro_MVC.Models;

namespace Wipro_MVC.Controllers
{
    public class WiproController : Controller
    {
        public IActionResult Index()
        {
            string str = "Dekh raha hai binod, Class chal raha hai";
            ViewData["Name"] = str;
            return View();
        }

        public string Name()
        {
            return "Hello, I'M chitti, Speed 1 Th Memory 1 Giga Byte";
        }

        public IActionResult Arithmetic()
        {
            int a = 15;
            int b = 5;
            string sum = $"Sum is {a + b}";
            string sub = $"Sub is {a - b}";
            string mul = $"Multiplication is {a * b}";
            string div = $"Division is {a / b}";
            ViewData["SumResult"] = sum;
            ViewData["SubResult"] = sub;
            ViewData["MulResult"] = mul;
            ViewData["DivResult"] = div;
            return View();
        }

        public IActionResult StudentInfo()
        {
            Student objStudent = new Student() 
            {
               StudentId="1",
               StudentName="Shankar",
               StudentEmail="shankarrentikota6@gmail.com",
               StudentPhone="7893668421"

            
            };

            ViewData["Student"] = objStudent;
            return View();

        }
    }
}
