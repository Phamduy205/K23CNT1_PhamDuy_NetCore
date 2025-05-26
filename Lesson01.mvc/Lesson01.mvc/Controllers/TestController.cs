using Microsoft.AspNetCore.Mvc;

namespace Lesson01.mvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
