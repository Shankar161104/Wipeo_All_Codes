

namespace Domain.DTOs
{
    public class SongDto
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } // Changed from int to TimeSpan
        public int ArtistID { get; set; }
    }
}
