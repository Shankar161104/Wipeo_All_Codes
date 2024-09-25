using Microsoft.AspNetCore.Mvc;


namespace Wipro_MVC_TempData_02nd.Controllers
{
    public class CountryC : Controller
    {
      
        public IActionResult Info()
        {
           
            List<string> countries = new List<string>
            {
                "India",
                "USA",
                "Canada",
                "Australia"
            };

            
            TempData["Countries"] = countries;

          
            return RedirectToAction("PassingData");
        }

        
        public IActionResult PassingData()
        {
           
            var countries = TempData["Countries"] as List<string>;

         
            ViewBag.Countries = countries;

            return View();
        }

       

    }
}
