using Microsoft.AspNetCore.Mvc;
using SecureFinancialManagement.Models;
using SecureFinancialManagement.Repository;

namespace SecureFinancialManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        // GET: /Account/Index
        public IActionResult Index()
        {
            var accounts = _accountRepository.GetAllAccounts();
            return View(accounts);
        }

        // GET: /Account/Details/5
        public IActionResult Details(int id)
        {
            var account = _accountRepository.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // GET: /Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                account.CreatedDate = DateTime.Now; // Set the creation date
                _accountRepository.InsertAccount(account);
                _accountRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: /Account/Edit/5
        public IActionResult Edit(int id)
        {
            var account = _accountRepository.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: /Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Account account)
        {
            if (id != account.AccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _accountRepository.UpdateAccount(account);
                _accountRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: /Account/Delete/5
        public IActionResult Delete(int id)
        {
            var account = _accountRepository.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: /Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _accountRepository.DeleteAccount(id);
            _accountRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
