using Microsoft.EntityFrameworkCore;
using SecureFinancialManagement.Data;
using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly FinancialDbContext _financialDbContext;

        public TransactionRepository(FinancialDbContext financialDbContext)
        {
            _financialDbContext = financialDbContext;
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _financialDbContext.Transactions.ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            return _financialDbContext.Transactions.Find(id);
        }

        public void InsertTransaction(Transaction transaction)
        {
            _financialDbContext.Transactions.Add(transaction);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _financialDbContext.Entry(transaction).State = EntityState.Modified;
        }

        public void DeleteTransaction(int id)
        {
            var transaction = _financialDbContext.Transactions.Find(id);
            if (transaction != null)
            {
                _financialDbContext.Transactions.Remove(transaction);
            }
        }

        public void Save()
        {
            _financialDbContext.SaveChanges();
        }
    }
}
