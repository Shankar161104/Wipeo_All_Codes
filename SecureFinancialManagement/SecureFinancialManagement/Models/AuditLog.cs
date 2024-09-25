namespace SecureFinancialManagement.Models
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public string Action { get; set; }
        public string Username { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
