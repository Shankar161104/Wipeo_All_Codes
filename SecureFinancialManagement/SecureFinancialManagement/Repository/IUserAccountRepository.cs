using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public interface IUserAccountRepository
    {
        User GetUserByUsername(string username);
        User GetUserById(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void Save();
    }
}
