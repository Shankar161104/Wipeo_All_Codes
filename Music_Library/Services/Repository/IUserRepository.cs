using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetUsersAsync();
        Task<IdentityUser> CreateUserAsync(string userName, string email, string password);
        Task<IdentityUser> GetUserByIdAsync(string userId);
        Task<IdentityUser> UpdateUserAsync(IdentityUser user);
        Task DeleteUserAsync(string userId);
    }
}
