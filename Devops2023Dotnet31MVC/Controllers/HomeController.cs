using Devops2023Dotnet31MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devops2023Dotnet31MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        private string password = "pass";
        private string mySecret = "secret";
        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            ViewBag.Password = _config.GetValue<string>("password");
            ViewBag.MySecret = _config.GetValue<string>("mysecret");

            _logger.LogInformation("This is a different log message");
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