using SecureFinancialManagement.Models;

namespace SecureFinancialManagement.Repository
{
    public interface IAuditLogRepository
    {
        IEnumerable<AuditLog> GetAllAuditLogs();
        AuditLog GetAuditLogById(int id);
        void InsertAuditLog(AuditLog auditLog);
        void UpdateAuditLog(AuditLog auditLog);
        void DeleteAuditLog(int id);
        void Save();
    }
}
