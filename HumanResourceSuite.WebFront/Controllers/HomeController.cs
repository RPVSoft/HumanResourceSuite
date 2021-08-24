using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HumarResourceSuite.WebFront.Models;
using HumanResourceSuite.WebFront.Framework;
using HumanResourceSuite.WebFront.ServiceClients;

namespace HumarResourceSuite.WebFront.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MasterServiceClient _masterServiceClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _masterServiceClient = new MasterServiceClient();
        }

        public async Task<IActionResult> Index()
        {
            var data = await _masterServiceClient.GetAll();
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
