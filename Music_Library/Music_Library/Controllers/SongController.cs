using Domain.Models;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Music_Library.Controllers
{
    public class SongController : Controller
    {
        private readonly HttpClient _client;
        private readonly string _apiAddress;

        public SongController(IConfiguration configuration)
        {
            _apiAddress = configuration["ApiAddress"];
            _client = new HttpClient { BaseAddress = new Uri(_apiAddress) };
        }

        // GET: Song/Index
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _client.GetAsync("api/SongAPI/GetSongs");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var songDtos = JsonConvert.DeserializeObject<List<SongDto>>(result);
                // Convert SongDto to Domain.Models.Song
                var songs = songDtos.Select(dto => new Domain.Models.Song
                {
                    SongID = dto.SongID,
                    Title = dto.Title,
                    Genre = dto.Genre,
                    Duration = TimeSpan.FromSeconds(dto.Duration),
                    ArtistID = dto.ArtistID
                }).ToList();

                return View(songs);
            }
            return View("Error");
        }


        // GET: Song/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Song/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SongDto songDto)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(songDto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync("api/SongAPI/Create", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Server error. Please contact administrator.");
            }
            return View(songDto);
        }

        // GET: Song/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/SongAPI/GetSongs/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var song = JsonConvert.DeserializeObject<SongDto>(result);
                return View(song);
            }
            return NotFound();
        }

        // POST: Song/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"api/SongAPI/Delete/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // GET: Song/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/SongAPI/GetSongs/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var song = JsonConvert.DeserializeObject<SongDto>(result);
                return View(song);
            }
            return NotFound();
        }

        // POST: Song/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SongDto songDto)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(songDto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync("api/SongAPI/Update", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Server error. Please contact administrator.");
            }
            return View(songDto);
        }
    }
}
