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
using HumanResourceSuite.WebFront.Models;
using Microsoft.AspNetCore.Authorization;
using javax.jws;

namespace HumarResourceSuite.WebFront.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MasterServiceClient _masterServiceClient;
        private readonly LeadServiceClient _leadServiceClient;
        private readonly CompanyServiceClient _companyServiceClient;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _masterServiceClient = new MasterServiceClient();
            _leadServiceClient = new LeadServiceClient();
        }
        
        public async Task<IActionResult> Index()
        {
           //var data = await _masterServiceClient.GetAll();
            return View();
        }

        public async Task<IActionResult> LeadIndex()
        {
            return View();
        }

        //public PartialViewResult EmployeeSelfPartial()
        //{
        //    return PartialView("_EmployeeSelf");
        //}



        //[WebMethod]
        //public static string LeadCreateAndUpdate([FromBody] LeadsModel leadsDTO)
        //{
        //    return "success";   //Json(data.ToString());
        //}

        [AcceptVerbs("Post", "GET")]
        public async Task<IActionResult> LeadCreateAndUpdate(LeadsModel leadsDTO)
        {
            //var data = await _leadServiceClient.Insert(leadsDTO);
            return PartialView("_IndexPartial");   //Json(data.ToString());
        }

       // [HttpPost]
        //public PartialViewResult LeadCreateAndUpdate1([FromBody] int id)
        //{
        //   // var data = await _leadServiceClient.Insert(leadsModel);
        //    return PartialView("_IndexPartial");   //Json(data.ToString());
        //}
       
        public async Task<IActionResult> CompanyIndex()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CompanyCreateAndUpdate([FromBody] CompanyDTO companyDTO)
        {
            var data = await _companyServiceClient.Insert(companyDTO);
            return Json(data.ToString());
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
