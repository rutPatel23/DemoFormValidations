using System.Diagnostics;
using DemoFormValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoFormValidations.Controllers
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
            Student st = new Student();
            return View(st);
        }

        [HttpPost]
        public IActionResult Index(Student st)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("ShowData", st);
            }
            return View(st);
        }

        public IActionResult ShowData(Student st) {
            return View(st);
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
