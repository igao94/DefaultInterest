using System.Diagnostics;
using DefaultInterest.Models;
using DefaultInterest.Services;
using Microsoft.AspNetCore.Mvc;

namespace DefaultInterest.Controllers
{
    public class HomeController(IInterestCalculatorService interestCalculatorService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InterestCalculator()
        {
            return View();
        }

        public IActionResult CalculateInterest(InterestRequest request)
        {
            var interest = interestCalculatorService
                .CalculateInterest(request.Debt, request.FromDate, request.ToDate);

            ViewBag.Interest = interest;

            return View("InterestCalculator", request);
        }

        public IActionResult Privacy()
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
