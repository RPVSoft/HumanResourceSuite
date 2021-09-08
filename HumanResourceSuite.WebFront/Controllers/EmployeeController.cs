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
    public class EmployeeController : BaseController
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly MasterServiceClient _masterServiceClient;
        private readonly LeadServiceClient _leadServiceClient;
        private readonly EmployeeServiceClient _employeeServiceClient;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
            _masterServiceClient = new MasterServiceClient();
            _leadServiceClient = new LeadServiceClient();
        }

        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult ProfileDetails()
        {
            return View("_Profile");
        }
       

        public IActionResult SelfDetails()
        {
            return View("_Self");
        }
        public IActionResult AddressDetails()
        {
            return View("_Address");
        }
        public IActionResult BankDetails()
        {
            return View("_Bank");
        }
        public IActionResult InvestmentDetails()
        {
            return View("_Investment");
        }
        public IActionResult LeaveAndAttendanceDetails()
        {
            return View("_LeaveAndAttendance");
        }
        public IActionResult QualificationDetails()
        {
            return View("_Qualification");
        }
        public IActionResult SalaryDetails()
        {
            return View("_Salary");
        }
        public IActionResult TenureDetails()
        {
            return View("_Tenure");
        }
        public IActionResult EmploymentDetails()
        {
            return View("_Employment");
        }

    }
}
