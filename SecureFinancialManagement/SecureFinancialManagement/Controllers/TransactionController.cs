using Microsoft.AspNetCore.Mvc;
using SecureFinancialManagement.Models;
using SecureFinancialManagement.Repository;
using System;
using System.Diagnostics;

namespace SecureFinancialManagement.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        // GET: Transactions/Index
        public IActionResult Index()
        {
            var transactions = _transactionRepository.GetAllTransactions();
            return View(transactions);
        }

        // GET: Transactions/Details/id
        public IActionResult Details(int id)
        {
            var transaction = _transactionRepository.GetTransactionById(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Transaction transaction)
        {
            Debug.WriteLine("Create POST action called");
            if (!ModelState.IsValid)
            {
                // Log model state errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Debug.WriteLine(error.ErrorMessage);
                }
                return View(transaction);
            }

            try
            {
                _transactionRepository.InsertTransaction(transaction);
                _transactionRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
                return View(transaction);
            }
        }

        // GET: Transactions/Delete/id
        public IActionResult Delete(int id)
        {
            var transaction = _transactionRepository.GetTransactionById(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _transactionRepository.DeleteTransaction(id);
            _transactionRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
