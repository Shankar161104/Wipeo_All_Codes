namespace SecureFinancialManagement.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation property for transactions
        public List<Transaction> Transactions { get; set; }
    }
}
