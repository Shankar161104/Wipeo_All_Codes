using Microsoft.AspNetCore.Mvc;

namespace UKMusicLibraryProject.ViewModel
{
    public class UserLoginViewModel
    {
        [HiddenInput]
        public Int32 Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? ArtistId { get; set; }
    }
}
