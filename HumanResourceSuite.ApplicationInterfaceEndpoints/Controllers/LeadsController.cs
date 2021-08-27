using HumanResourceSuite.ApplicationInterfaceEndpoints.Framework;
using HumanResourceSuite.BusinessProviders.IProviders;
using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceSuite.ApplicationInterfaceEndpoints.Controllers
{

    /// <summary>
    /// Leads Controller - Handles Leads data operations
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LeadsController : HumanResourceSuiteControllerBase
    {
        private readonly ILogger<LeadsController> _logger;
        private readonly IOptions<AppSettings> _options;
        private readonly ILeadsProvider _leadsProvider;


        /// <summary>
        /// Lead Contructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="options"></param>
        /// <param name="leadsProvider"></param>
        public LeadsController(ILogger<LeadsController> logger, IOptions<AppSettings> options, ILeadsProvider leadsProvider)
        {
            _logger = logger;
            _options = options;
            _leadsProvider = leadsProvider;
        }

        /// <summary>
        /// GetLeadsById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetLeadsById(int id)
        {
            SingleResponseDTO<LeadsDTO> response = new SingleResponseDTO<LeadsDTO>();
            Exception exception;
            response.Result = _leadsProvider.GetLeadsById(id, _options.Value, out exception);
            if (exception != null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ErrorMessage = exception;
                // Log exception into database
            }
            else if (response.Result == null)
                Response.StatusCode = StatusCodes.Status204NoContent;
            else
                Response.StatusCode = StatusCodes.Status200OK;

            return new JsonResult(response);
        }

        /// <summary>
        /// Get all Leads
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        [Produces("application/json")]
        public IActionResult GetAllLeads()
        {
            MultiResponseDTO<LeadsDTO> response = new MultiResponseDTO<LeadsDTO>();
            Exception exception;
            response.Data = _leadsProvider.GetAllLeads(_options.Value, out exception);
            if (exception != null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ErrorMessage = exception;
            }
            else if (response.Data.Count <= 0)
                Response.StatusCode = StatusCodes.Status204NoContent;
            else
                Response.StatusCode = StatusCodes.Status200OK;
            return new JsonResult(response);
        }

        /// <summary>
        /// Insert Leads into the Database
        /// </summary>
        /// <param name="leadsDTO"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("Insert")]
        [Produces("application/json")]
        public IActionResult CreateLeads([FromBody] LeadsDTO leadsDTO)
        {
            SingleResponseDTO<LeadsDTO> response = new SingleResponseDTO<LeadsDTO>();
            Exception exception;
            response.Result = _leadsProvider.CreateLeads(leadsDTO, _options.Value, out exception);
            if (exception != null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ErrorMessage = exception;
            }
            else if (response.Result == null)
                Response.StatusCode = StatusCodes.Status204NoContent;
            else
                Response.StatusCode = StatusCodes.Status200OK;
            return new JsonResult(response);
        }
    }
}
