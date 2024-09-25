using Microsoft.AspNetCore.Mvc;
using SecureFinancialManagement.Models;
using SecureFinancialManagement.Repository;
using SecureFinancialManagement.ViewModel;
using System.Diagnostics;

namespace SecureFinancialManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITransactionRepository _transactionRepository;
        private readonly IAccountRepository _accountRepository;

        public HomeController(ILogger<HomeController> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AccountSummary()
        {
            var accounts = _accountRepository.GetAllAccounts();
            var transactions = _transactionRepository.GetAllTransactions();

            var accountSummary = accounts.Select(account => new AccountSummaryItem
            {
                AccountId = account.AccountId,
                AccountHolderName = account.AccountHolderName,
                Balance = account.Balance,
                CreatedDate = account.CreatedDate,
              
            });

            var viewModel = new AccountSummaryViewModel
            {
                Accounts = accountSummary
            };

            return View(viewModel);
        }







        public IActionResult OpeningPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
