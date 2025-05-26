using Microsoft.AspNetCore.Mvc;
using PvdLesson03.Models;
using System.Diagnostics;

namespace PvdLesson03.Controllers
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
            ViewBag.About = "Pham Duy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult PvdProfile()
        {
            return View();
        }
        public IActionResult PvdRazorcode()
        {
            return View();
        }
        
    }
}
