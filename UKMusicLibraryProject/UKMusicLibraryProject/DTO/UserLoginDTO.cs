using System.ComponentModel.DataAnnotations;

namespace UKMusicLibraryProject.DTO
{
    public class UserLoginDTO
    {
        public Int64 Id { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Is Required")]

        public string Email { get; set; }

        public int? ArtistId { get; set; }

    }
}
