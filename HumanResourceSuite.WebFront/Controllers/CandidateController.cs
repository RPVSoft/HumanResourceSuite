using HumanResourceSuite.WebFront.Framework;
using HumanResourceSuite.WebFront.ServiceClients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceSuite.WebFront.Controllers
{
    public class CandidateController : BaseController
    {
        private readonly ILogger<CandidateController> _logger;
        private readonly MasterServiceClient _masterServiceClient;
        private readonly LeadServiceClient _leadServiceClient;
        private readonly EmployeeServiceClient _employeeServiceClient;
        public CandidateController(ILogger<CandidateController> logger)
        {
            _logger = logger;
            _masterServiceClient = new MasterServiceClient();
            _leadServiceClient = new LeadServiceClient();
        }

        public async Task<IActionResult> CandidateIndex()
        {
            //var data = await _employeeServiceClient.GetAll();
            return View();
        }
    }
}
