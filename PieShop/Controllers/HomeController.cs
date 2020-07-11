using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PieShop.Models;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILog _log;

        public HomeController(ILogger<HomeController> logger) //, ILog log)
        {
            _logger = logger;
           // _log = log;
        }

        public IActionResult Index()
        {
            //_log.Info("We are on home page");
            var services = this.HttpContext.RequestServices;
            var log = (ILog)services.GetService(typeof(ILog));

            log.Info("Index is executing");

            return View();
        }

        public IActionResult Privacy([FromServices] ILog log)
        {
            //  throw new Exception();
            log.Info("Pravicy page");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
