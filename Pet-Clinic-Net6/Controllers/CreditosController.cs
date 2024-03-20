using Microsoft.AspNetCore.Mvc;
using Pet_Clinic_Net6.Models;
using System.Diagnostics;

namespace Pet_Clinic_Net6.Controllers
{
    public class CreditosController : Controller
    {
        private readonly ILogger<CreditosController> _logger;

        public CreditosController(ILogger<CreditosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
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
