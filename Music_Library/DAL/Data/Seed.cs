using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace DAL.Data
{
    public static class Seed
    {
        public static async Task Initialize(UserManager<User> userManager)
        {
            // Check if any users exist
            if (userManager.Users.Any())
            {
                return; // DB has been seeded
            }

            // Add seed data
            var users = new User[]
            {
        new User { UserName = "admin", Email = "admin@example.com" },
        new User { UserName = "user1", Email = "user1@example.com" }
            };

            var hasher = new PasswordHasher<User>();

            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, "admin123"); // Use a static password or change as needed
                await userManager.CreateAsync(user);
            }
        }

    }
}
