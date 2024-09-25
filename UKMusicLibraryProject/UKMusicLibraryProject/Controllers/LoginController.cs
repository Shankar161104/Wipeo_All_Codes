using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using UKMusicLibraryProject.ViewModel;

namespace UKMusicLibraryProject.Controllers
{
    public class LoginController : Controller
    {
        HttpClient client;
        IConfiguration configuration;

        public LoginController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }

        [HttpGet, AllowAnonymous]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginViewModel modelLogin)
        {
            if (ModelState.IsValid)
            {
                List<UserLoginViewModel> lstUsers = new List<UserLoginViewModel>();
                HttpResponseMessage res = await client.GetAsync("api/LoginAPI/CheckLisOfUsers");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    lstUsers = JsonConvert.DeserializeObject<List<UserLoginViewModel>>(result);
                    var Data = lstUsers.FirstOrDefault(u=>u.Email==modelLogin.Email);
                    if (Data != null)
                    {
                        bool isValid = (Data.Email == modelLogin.Email && Data.Password == modelLogin.Password);
                            if (isValid)
                        {
                            var UserClaims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Email,Data.Email),
                                new Claim(ClaimTypes.Role,Data.Id==1?"Admin":"User"),
                                new Claim("UserId",Convert.ToString(Data.Id)),
                                new Claim("ArtistId",Convert.ToString(Data.ArtistId ??0)),

                            };

                            var userIdentity = new ClaimsIdentity(UserClaims,Data.Id==1?"Admin":"User");

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(userIdentity));
                            if (Data.Id == 1)
                            {
                                return RedirectToAction("Index", "User");
                            }
                            else
                                return RedirectToAction("Index","Home");

                        }
                        else
                        {
                            TempData["errorPassword"] = "Invalid Password!";
                            return View(modelLogin);

                        }
                    }
                    else
                    {
                        TempData["errorUserName"] = "User Not Found";
                        return View(modelLogin);
                    }
                }
                else
                {
                    TempData["errorApi"] = "Cant connect to API";
                    return View(modelLogin);


                }

            }
            else
            {
                return View(modelLogin);
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Delete(".AspNetCore.Cookies");
            return RedirectToAction("login","Login");
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
