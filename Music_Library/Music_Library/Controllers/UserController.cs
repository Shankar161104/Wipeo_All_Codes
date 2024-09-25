using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Music_Library.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _client;
        private readonly string _apiAddress;

        public UserController(IConfiguration configuration)
        {
            _apiAddress = configuration["ApiAddress"];
            _client = new HttpClient { BaseAddress = new Uri(_apiAddress) };
        }

        // GET: User/Index
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _client.GetAsync("api/UserAPI/GetUsers");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<UserDto>>(result);

                // Ensure correct mapping from UserDto to Domain.Models.User
                var userModels = users.Select(dto => new Domain.Models.User
                {
                    Id = dto.Id, // Correctly use Id from UserDto
                    UserName = dto.UserName,
                    Email = dto.Email
                }).ToList();

                return View(userModels);
            }
            return View("Error"); // Ensure you have an "Error" view or handle appropriately
        }

        public IActionResult NavigateToUserIndex()
        {
            return RedirectToAction("Index", "User");
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(userDto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync("api/UserAPI/Create", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Server error. Please contact administrator.");
            }
            return View(userDto);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/UserAPI/GetUsers/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<UserDto>(result);
                return View(user);
            }
            return NotFound();
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"api/UserAPI/Delete/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/UserAPI/GetUsers/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<UserDto>(result);
                return View(user);
            }
            return NotFound();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(userDto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync("api/UserAPI/Update", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Server error. Please contact administrator.");
            }
            return View(userDto);
        }
    }
}
