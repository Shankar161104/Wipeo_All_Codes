namespace Music_Library.DTO
{
    public class UserDto
    {
        public string Id { get; set; } // Use Id to match IdentityUser's Id property
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
