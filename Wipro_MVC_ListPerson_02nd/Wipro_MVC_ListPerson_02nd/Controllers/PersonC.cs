using Microsoft.AspNetCore.Mvc;
using Wipro_MVC_ListPerson_02nd.Models;
using System.Collections.Generic;

namespace Wipro_MVC_ListPerson_02nd.Controllers
{
    public class PersonC : Controller
    {
        public ActionResult Index()
        {
        
            List<Person> lstPerson = new List<Person>();

         
            Person objPerson1 = new Person
            {
                PersonID = 1,
                PersonName = "John Doe",
                PersonAge = 30,
                PersonEmail = "john.doe@example.com",
                PersonCity = "New York"
            };
            lstPerson.Add(objPerson1);

          
            Person objPerson2 = new Person
            {
                PersonID = 2,
                PersonName = "Jane Smith",
                PersonAge = 25,
                PersonEmail = "jane.smith@example.com",
                PersonCity = "Los Angeles"
            };
            lstPerson.Add(objPerson2);

           
            ViewData["Person"] = lstPerson;

       
            return View();
        }
    }
}
