using baitap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace baitap.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
