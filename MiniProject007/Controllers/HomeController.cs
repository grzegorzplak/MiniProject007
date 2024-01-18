using Microsoft.AspNetCore.Mvc;
using MiniProject007.Models;
using System.Diagnostics;

namespace MiniProject007.Controllers
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
        public IActionResult PageTextbox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageTextbox(string? name)
        {
            if (name is null)
            {
                return RedirectToAction("PageTextbox");    
            }
            ViewBag.Name = name;
            return View();
        }

        [HttpGet]
        public IActionResult PageSelect()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageSelect(string favouriteColor)
        {
            ViewBag.FavouriteColor = (favouriteColor != null) ? favouriteColor : "";
            return View();
        }

        [HttpGet]
        public IActionResult PageRadio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageRadio(string englishLevel)
        {
            ViewBag.EnglishLevel = (englishLevel != null) ? englishLevel : "";
            return View();
        }

        [HttpGet]
        public IActionResult PageCheckbox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageCheckbox(string isActive)
        {
            ViewBag.IsActive = (isActive != null) ? isActive : "not active";
            return View();
        }

        [HttpGet]
        public IActionResult PageCheckbox2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageCheckbox2(string[] continent)
        {
            ViewBag.Continent = (continent != null) ? continent : new string[0];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
