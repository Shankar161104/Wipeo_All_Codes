using Microsoft.EntityFrameworkCore;
using SecureFinancialManagement.Data;
using SecureFinancialManagement.Models;
using SecureFinancialManagement.Repository;

public class AuditLogRepository : IAuditLogRepository
{
    private readonly FinancialDbContext _financialDbContext;

    public AuditLogRepository(FinancialDbContext financialDbContext)
    {
        _financialDbContext = financialDbContext;
    }

    public IEnumerable<AuditLog> GetAllAuditLogs()
    {
        return _financialDbContext.AuditLogs.ToList();
    }

    public AuditLog GetAuditLogById(int id)
    {
        return _financialDbContext.AuditLogs.Find(id);
    }

    public void InsertAuditLog(AuditLog auditLog)
    {
        _financialDbContext.AuditLogs.Add(auditLog);
    }

    public void UpdateAuditLog(AuditLog auditLog)
    {
        _financialDbContext.Entry(auditLog).State = EntityState.Modified;
    }

    public void DeleteAuditLog(int id)
    {
        var auditLog = _financialDbContext.AuditLogs.Find(id);
        if (auditLog != null)
        {
            _financialDbContext.AuditLogs.Remove(auditLog);
        }
    }

    public void Save()
    {
        _financialDbContext.SaveChanges();
    }
}
