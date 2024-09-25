using System;

namespace Domain.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ArtistID { get; set; } // Changed from string to int
        public TimeSpan Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
