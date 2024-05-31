using Admin.ControlData;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WebDataContext cn = new WebDataContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (StateAdmin.nv == null)
            {
                return RedirectToAction("Login", "User");
            }
            ViewData["User"] = StateAdmin.nv.HoTenNv;
            return View();
        }
        public IActionResult Logout()
        {
            StateAdmin.nv = null;
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
