using Microsoft.AspNetCore.Mvc;
using MVC_Practice_Car.Models;

namespace MVC_Practice_Car.Controllers
{
    public class Tata : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Nexon()
        {
            Engine objEngine = new Engine();
            Engine.ICEngine();
            objEngine.TypeOfEngine = "Internal Combustion";
            objEngine.NoOfCylinders = 6;
            objEngine.Torque = 1600;

            BrakingSystem objBrake = new BrakingSystem();
            objBrake.TypeOfBrake = "Front And Rear";
            objBrake.NoOfBrakes = 4;
            objBrake.Material = "Cast-Iron";

            Transmission objTransmission = new Transmission();
            objTransmission.TypeOfTransmission = "Automatic";
            objTransmission.NoOfGears = 4;
            objTransmission.GearRatio = 31.2f;

            Car objCar = new Car()
            {
                Engine1 = objEngine,
                BrakingSystem1=objBrake,
                Transmission1=objTransmission

            };

            return View("RatanTata",objCar);
            
        }
    }
}
