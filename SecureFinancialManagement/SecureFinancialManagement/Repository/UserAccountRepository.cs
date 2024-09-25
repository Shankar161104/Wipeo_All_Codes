using Microsoft.EntityFrameworkCore;
using SecureFinancialManagement.Data;
using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly FinancialDbContext _financialDbContext;

        public UserAccountRepository(FinancialDbContext financialDbContext)
        {
            _financialDbContext = financialDbContext;
        }

        public User GetUserByUsername(string username)
        {
            return _financialDbContext.Users.SingleOrDefault(u => u.Username == username);
        }

        public User GetUserById(int id)
        {
            return _financialDbContext.Users.Find(id);
        }

        public void InsertUser(User user)
        {
            _financialDbContext.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            _financialDbContext.Entry(user).State = EntityState.Modified;
        }

        public void DeleteUser(int id)
        {
            var user = _financialDbContext.Users.Find(id);
            if (user != null)
            {
                _financialDbContext.Users.Remove(user);
            }
        }

        public void Save()
        {
            _financialDbContext.SaveChanges();
        }
    }
}
