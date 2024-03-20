using Microsoft.AspNetCore.Mvc;
using Pet_Clinic_Net6.Models;
using System.Diagnostics;

namespace Pet_Clinic_Net6.Controllers
{
    public class DevOpsController : Controller
    {
        private readonly ILogger<DevOpsController> _logger;

        public DevOpsController(ILogger<DevOpsController> logger)
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
