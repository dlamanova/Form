using Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Form.Controllers
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

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Data data)
        {
            if (ModelState.IsValid)
            {
                return View("Result", data);
            }
            else return View();
        }

        [HttpGet]
        public IActionResult VolunteerForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VolunteerForm(VolunteerForm data)
        {
            if (ModelState.IsValid)
            {
                return View("Success", data);
            }
            return View();
        }

        public IActionResult Success(VolunteerForm data)
        {
            return View(data);
        }

        public IActionResult Result(Data data)
        {
            return View(data);
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
