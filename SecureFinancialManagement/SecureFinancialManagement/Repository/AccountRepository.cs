using Microsoft.EntityFrameworkCore;
using SecureFinancialManagement.Data;
using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly FinancialDbContext _financialDbContext;

        public AccountRepository(FinancialDbContext financialDbContext)
        {
            _financialDbContext = financialDbContext;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _financialDbContext.Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _financialDbContext.Accounts.Find(id);
        }

        public void InsertAccount(Account account)
        {
            _financialDbContext.Accounts.Add(account);
        }

        public void UpdateAccount(Account account)
        {
            _financialDbContext.Entry(account).State = EntityState.Modified;
        }

        public void DeleteAccount(int id)
        {
            var account = _financialDbContext.Accounts.Find(id);
            if (account != null)
            {
                _financialDbContext.Accounts.Remove(account);
            }
        }

        public void Save()
        {
            _financialDbContext.SaveChanges();
        }
    }
}
