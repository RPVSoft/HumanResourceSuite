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
    /// Company Controller - Handles Company data operations
    /// </summary>

    [ApiController]
    [Route("[controller]")]
    public class CompanyController : HumanResourceSuiteControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly IOptions<AppSettings> _options;
        private readonly ICompanyProvider _companyProvider;

       /// <summary>
       /// Company Constructor
       /// </summary>
       /// <param name="logger"></param>
       /// <param name="options"></param>
       /// <param name="companyProvider"></param>
        public CompanyController(ILogger<CompanyController> logger, IOptions<AppSettings> options, ICompanyProvider companyProvider)
        {
            _logger = logger;
            _options = options;
            _companyProvider = companyProvider;
        }

        /// <summary>
        /// Get Company Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetCompanyDetailsById(int id)
        {
            SingleResponseDTO<CompanyDTO> response = new SingleResponseDTO<CompanyDTO>();
            Exception exception;
            response.Result = _companyProvider.GetCompanyDetailsById(id, _options.Value, out exception);
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
        /// Get Company Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        [Produces("application/json")]
        public IActionResult GetCompanyDetails()
        {
            MultiResponseDTO<CompanyDTO> response = new MultiResponseDTO<CompanyDTO>();
            Exception exception;
            response.Data = _companyProvider.GetCompanyDetails(_options.Value, out exception);
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
        /// Feed Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Insert")]
        [Produces("application/json")]
        public IActionResult InsertCompanyDetails([FromBody] CompanyDTO companyDTO)
        {
            SingleResponseDTO<CompanyDTO> response = new SingleResponseDTO<CompanyDTO>();
            Exception exception;
            response.Result = _companyProvider.InsertCompanyDetails(companyDTO, _options.Value, out exception);
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

        /// <summary>
        /// Modify Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        [Produces("application/json")]
        public IActionResult UpdateCompanyDetails([FromBody] CompanyDTO companyDTO)
        {
            SingleResponseDTO<CompanyDTO> response = new SingleResponseDTO<CompanyDTO>();
            Exception exception;
            response.Result = _companyProvider.UpdateCompanyDetails(companyDTO, _options.Value, out exception);
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

        /// <summary>
        /// Delete Company Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{id:int}")]
        [Produces("application/json")]
        public IActionResult DeleteCompanyDetails(int id)
        {
            SingleResponseDTO<string> response = new SingleResponseDTO<string>();
            Exception exception;
            response.Result = _companyProvider.DeleteCompanyDetails(id, _options.Value, out exception);
            if (exception != null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ErrorMessage = exception;
            }
            else if (string.IsNullOrEmpty(response.Result))
                Response.StatusCode = StatusCodes.Status204NoContent;
            else
                Response.StatusCode = StatusCodes.Status200OK;
            return new JsonResult(response);
        }
    }   
}
