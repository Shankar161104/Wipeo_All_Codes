using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Wipro_APIAndViewInSameProject.Models;
using Wipro_APIAndViewInSameProject.Repository;

namespace Wipro_APIAndViewInSameProject.Controllers
{
    public class CustomerController : Controller
    {

        HttpClient client;
        IConfiguration iconfiguration;

        public CustomerController(IConfiguration configuration)
        {
            iconfiguration = configuration;
            string apiAddress = iconfiguration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }





        public async Task<IActionResult> Index()
        {
            List<Customer> model = new List<Customer>();
            HttpResponseMessage res = await client.GetAsync("api/CustomerAPI/CustomerList");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<Customer>>(result);
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(Customer customer)
        {
            string url = "api/CustomerAPI/CreateCustomer";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url,customer);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty,"Server Error");
                }
            }
            return View();
        }




        public async Task<IActionResult> Edit(int? id)
        {
            Customer objCustomer = new Customer();
            string url = "api/CustomerAPI/SearchCustomerByID?CustomerId=";
            using (var response = await client.GetAsync(url+id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objCustomer = JsonConvert.DeserializeObject<Customer>(result);

            }
            return View(objCustomer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            string url = "api/CustomerAPI/UpdateCustomer";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url,customer);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server Error");
                }
            }
            return View();
        }



        public async Task<IActionResult> Delete(int id)

        {
           Customer objCustomer = new Customer();

            string url = "api/CustomerAPI/SearchCustomerById?CustomerId=";

            using (var response = await client.GetAsync(url + id))

            {

                var result = response.Content.ReadAsStringAsync().Result;

                objCustomer = JsonConvert.DeserializeObject<Customer>(result);

            }

            return View(objCustomer);

        }

        [HttpPost, ActionName("DeleteCustomer")]

        public async Task<IActionResult> Delete(Customer customer)

        {

            string url = "api/CustomerAPI/DeleteCustomer";

            await client.DeleteAsync(url + customer);

            return RedirectToAction("Index");

        }




        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            Customer objCustomer = new Customer();
            string url = "api/CustomerAPI/GetCustomerswithId?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objCustomer = JsonConvert.DeserializeObject<Customer>(result);
            }
            return View(objCustomer);
        }








    }
}
