using System.Transactions;

namespace SecureFinancialManagement.ViewModel
{
    public class AccountSummaryViewModel
    {
        public IEnumerable<AccountSummaryItem> Accounts { get; set; }
    }
}
