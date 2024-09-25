using Domain.Models;
using Music_Library.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DTOs;

namespace Music_Library.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongAPIController : ControllerBase
    {
        private readonly ISongRepository songRepository;

        public SongAPIController(ISongRepository _songRepository)
        {
            songRepository = _songRepository;
        }

        [HttpGet("GetSongs")]
        public ActionResult<IEnumerable<SongDto>> GetSongs()
        {
            var songs = songRepository.GetSongs(); // Assuming this returns IEnumerable<Song>
            var songDtos = songs.Select(song => new SongDto
            {
                SongID = song.SongID,
                Title = song.Title,
                Genre = song.Genre,
                Duration = (int)song.Duration.TotalSeconds, // Convert TimeSpan to seconds
                ArtistID = song.ArtistID
            });
            return Ok(songDtos);
        }

        [HttpPost("Create")]
        public ActionResult CreateSong(SongDto songDto)
        {
            var song = new Song
            {
                SongID = songDto.SongID,
                Title = songDto.Title,
                Genre = songDto.Genre,
                Duration = TimeSpan.FromSeconds(songDto.Duration), // Convert seconds to TimeSpan
                ArtistID = songDto.ArtistID
            };
            var result = songRepository.CreateSong(song);
            return Ok(result);
        }

        [HttpPost("Update")]
        public ActionResult UpdateSong(SongDto songDto)
        {
            var song = new Song
            {
                SongID = songDto.SongID,
                Title = songDto.Title,
                Genre = songDto.Genre,
                Duration = TimeSpan.FromSeconds(songDto.Duration), // Convert seconds to TimeSpan
                ArtistID = songDto.ArtistID
            };
            var result = songRepository.UpdateSong(song);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult DeleteSong(int id)
        {
            var result = songRepository.DeleteSong(id);
            return Ok(result);
        }
    }
}
