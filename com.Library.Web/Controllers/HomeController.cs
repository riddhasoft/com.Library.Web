using com.Library.Web.Controllers.ViewModel;
using com.Library.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace com.Library.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(model);
                _context.SaveChanges();

                return Redirect("/Users/Login");
            }
            return View();
        }
    }
}