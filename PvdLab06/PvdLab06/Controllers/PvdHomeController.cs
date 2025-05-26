using Microsoft.AspNetCore.Mvc;
using PvdLab06.Models;
using System.Diagnostics;

namespace PvdLab06.Controllers
{
    public class PvdHomeController : Controller
    {
        private readonly ILogger<PvdHomeController> _logger;

        public PvdHomeController(ILogger<PvdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PvdIndex()
        {
            return View();
        }

        public IActionResult PvdAbout()
        {
            return View();
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
