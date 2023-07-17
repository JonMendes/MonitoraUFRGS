using Microsoft.AspNetCore.Mvc;
using MonitoraUFRGS_APP.Models;
using System.Diagnostics;

namespace MonitoraUFRGS_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult SolicitarAula()
        {
            return View();
        }

        public IActionResult Confirmar()
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