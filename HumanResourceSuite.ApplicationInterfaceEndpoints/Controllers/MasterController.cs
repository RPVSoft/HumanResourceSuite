using System;
using System.Threading.Tasks;
using HumanResourceSuite.ApplicationInterfaceEndpoints.Framework;
using HumanResourceSuite.BusinessProviders.IProviders;
using HumanResourceSuite.BusinessProviders.Providers;
using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HumanResourceSuite.ApplicationInterfaceEndpoints.Controllers
{
    /// <summary>
    /// Master Controller - Handles master data operations
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MasterController : HumanResourceSuiteControllerBase
    {
        private readonly ILogger<MasterController> _logger;
        private readonly IOptions<AppSettings> _options;
        private readonly IMasterProvider _masterProvider;
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="options"></param>
        /// <param name="masterProvider"></param>
        public MasterController(ILogger<MasterController> logger, IOptions<AppSettings> options, IMasterProvider masterProvider)
        {
            _logger = logger;
            _options = options;
            _masterProvider = masterProvider;
        }


        /// <summary>
        /// Get master data based on master type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/{id:int}")]
        [Produces("application/json")]
        public IActionResult Get(int id)
        {
            MultiResponseDTO<MasterDTO> response = new MultiResponseDTO<MasterDTO>();
            Exception exception;
            response.Data = _masterProvider.Get(id, _options.Value, out exception);
            if (exception != null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ErrorMessage = exception;
                // Log exception into database
            }
            else if (response.Data.Count <= 0)
                Response.StatusCode = StatusCodes.Status204NoContent;
            else
                Response.StatusCode = StatusCodes.Status200OK;

            return new JsonResult(response);
        }


        /// <summary>
        /// Get all master data from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        [Produces("application/json")]
        public IActionResult GetAll()
        {
            MultiResponseDTO<MasterDTO> response = new MultiResponseDTO<MasterDTO>();
            Exception exception;
            response.Data = _masterProvider.GetAll(_options.Value, out exception);
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
    }
}
