using Microsoft.AspNetCore.Mvc;
using SecureFinancialManagement.Models;
using SecureFinancialManagement.Repository;

namespace SecureFinancialManagement.Controllers
{
    public class AuditLogController : Controller
    {
        private readonly IAuditLogRepository _auditLogRepository;

        public AuditLogController(IAuditLogRepository auditLogRepository)
        {
            _auditLogRepository = auditLogRepository;
        }

        // GET: /AuditLog/Index
        public IActionResult Index()
        {
            var auditLogs = _auditLogRepository.GetAllAuditLogs();
            return View(auditLogs);
        }

        // GET: /AuditLog/Details/5
        public IActionResult Details(int id)
        {
            var auditLog = _auditLogRepository.GetAuditLogById(id);
            if (auditLog == null)
            {
                return NotFound();
            }
            return View(auditLog);
        }

        // GET: /AuditLog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /AuditLog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AuditLog auditLog)
        {
            if (ModelState.IsValid)
            {
                _auditLogRepository.InsertAuditLog(auditLog);
                _auditLogRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(auditLog);
        }

        // GET: /AuditLog/Edit/5
        public IActionResult Edit(int id)
        {
            var auditLog = _auditLogRepository.GetAuditLogById(id);
            if (auditLog == null)
            {
                return NotFound();
            }
            return View(auditLog);
        }

        // POST: /AuditLog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, AuditLog auditLog)
        {
            if (id != auditLog.AuditLogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _auditLogRepository.UpdateAuditLog(auditLog);
                _auditLogRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(auditLog);
        }

        // GET: /AuditLog/Delete/5
        public IActionResult Delete(int id)
        {
            var auditLog = _auditLogRepository.GetAuditLogById(id);
            if (auditLog == null)
            {
                return NotFound();
            }
            return View(auditLog);
        }

        // POST: /AuditLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _auditLogRepository.DeleteAuditLog(id);
            _auditLogRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}

