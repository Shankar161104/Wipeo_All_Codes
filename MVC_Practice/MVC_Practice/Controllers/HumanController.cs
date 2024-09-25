using Microsoft.AspNetCore.Mvc;
using MVC_Practice.Models;

namespace MVC_Practice.Controllers
{
    public class HumanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      

        public ActionResult HumanInfo()
        {
            Human objHuman = new Human();
            objHuman.HumanID = 1;
            objHuman.HumanName = "Shankar";
            objHuman.HumanCity = "Vizianagaram";

            ViewData["Human"] = objHuman;

            return View("Shankar");
        }

        public ActionResult ArithmeticHuman()
        {
            Arithmetic objArithmetic = new Arithmetic();
            objArithmetic.Addition = 4 + 5 + 8;
            objArithmetic.Subtraction = 25 - 5 - 0;
            objArithmetic.Multiplication = 4 * 4;

            Human objHuman = new Human();
            objHuman.HumanID = 101;
            objHuman.HumanName = "Dattu";
            objHuman.HumanCity = "Vijayawada";

            ArithmeticHuman objArithHuman = new ArithmeticHuman() 
            {
               ArithmeticData=objArithmetic,
               HumanData=objHuman
            };
            return View(objArithHuman);
        }

    }
}
