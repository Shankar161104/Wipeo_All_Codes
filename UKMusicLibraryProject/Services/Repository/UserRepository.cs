using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public void DeleteUser(long id)
        {
            var user = this.applicationDbContext.Users.FirstOrDefault(u=>u.UserID==id);
            var userDelete = this.applicationDbContext.Users.Remove(user);
            applicationDbContext.SaveChanges();

        }

        public User GetUser(long id)
        {
            var user = this.applicationDbContext.Users.FirstOrDefault(u => u.UserID == id);
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            return this.applicationDbContext.Users.ToList();
        }

        public int InsertUser(User user)
        {
            this.applicationDbContext.Users.Add(user);
            return applicationDbContext.SaveChanges();
        }

        public int UpdateUser(User user)
        {
             this.applicationDbContext.Users.Update(user);
             return applicationDbContext.SaveChanges();
        }
    }
}
