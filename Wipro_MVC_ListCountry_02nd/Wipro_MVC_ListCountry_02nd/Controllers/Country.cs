using Microsoft.AspNetCore.Mvc;

namespace Wipro_MVC_ListCountry_02nd.Controllers
{
    public class Country : Controller
    {
        public ActionResult Index()
        {
            List<string> lstCountry = new List<string>();
            lstCountry.Add("Bharat");
            lstCountry.Add("Japan");
            lstCountry.Add("China");
            lstCountry.Add("USA");
            lstCountry.Add("Deutschland");
            lstCountry.Add("Australia");

            ViewData["Country"] = lstCountry;
            return View();
        }
    }
}
