using System.Transactions;

namespace SecureFinancialManagement.ViewModel
{
    public class AccountSummaryItem
    {

        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}
