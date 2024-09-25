using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositorty
{
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public void DeleteUser(int id)
        {
            UserProfile userProfile = applicationDbContext.UserProfiles.SingleOrDefault(x=>x.Id==id);
            applicationDbContext.UserProfiles.Remove(userProfile);

            User user = applicationDbContext.Users.SingleOrDefault(x=>x.Id==id);
            applicationDbContext.Users.Remove(user);
            applicationDbContext.SaveChanges();
        }

        public User GetUser(long id)
        {
            return applicationDbContext.Users.SingleOrDefault(x=>x.Id==id);
        }

        public IEnumerable<User> GetUsers()
        {
            return applicationDbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            applicationDbContext.Users.Add(user);
            applicationDbContext.SaveChanges();
        }

       public void UpdateUser(User user)
        {
            applicationDbContext.Users.Update(user);
            applicationDbContext.SaveChanges();
        }
    }
}
