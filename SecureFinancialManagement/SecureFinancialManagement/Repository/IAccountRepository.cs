using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(int id);
        void InsertAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int id);
        void Save();
    }
}
