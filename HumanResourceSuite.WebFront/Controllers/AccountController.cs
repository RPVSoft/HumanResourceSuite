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
using HumanResourceSuite.DataObjects;


namespace HumanResourceSuite.WebFront.Controllers
{
    public class AccountController : BaseController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly MasterServiceClient _masterServiceClient;
        private readonly LeadServiceClient _leadServiceClient;
        private readonly CompanyServiceClient _companyServiceClient;
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
            _masterServiceClient = new MasterServiceClient();
            _leadServiceClient = new LeadServiceClient();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }
    }
}
