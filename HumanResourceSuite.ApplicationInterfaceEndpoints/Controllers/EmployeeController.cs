﻿using HumanResourceSuite.ApplicationInterfaceEndpoints.Framework;
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
    /// Employee Controller - Handles Employee data operations
    /// </summary>

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : HumanResourceSuiteControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IOptions<AppSettings> _options;
        private readonly IEmployeeProviders _employeeProvider;

        /// <summary>
        ///Employee Constructor 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="options"></param>
        /// <param name="employeeProvider"></param>
        public EmployeeController(ILogger<EmployeeController> logger, IOptions<AppSettings> options, IEmployeeProviders employeeProvider)
        {
            _logger = logger;
            _options = options;
            _employeeProvider = employeeProvider;
        }

        /// <summary>
        /// Get Employee Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeDetailsById(int id)
        {
            SingleResponseDTO<EmployeeDTO> response = new SingleResponseDTO<EmployeeDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeDetailsById(id, _options.Value, out exception);
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
        /// Get Employee Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        [Produces("application/json")]
        public IActionResult GetEmployeeDetails()
        {
            MultiResponseDTO<EmployeeDTO> response = new MultiResponseDTO<EmployeeDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeDetails(_options.Value, out exception);
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
        /// Insert Employee Details
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Insert")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeDetails([FromBody] EmployeeDTO employeeDTO)
        {
            SingleResponseDTO<EmployeeDTO> response = new SingleResponseDTO<EmployeeDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeDetails(employeeDTO, _options.Value, out exception);
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
        /// Modify Employee Details
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeDetails([FromBody] EmployeeDTO employeeDTO)
        {
            SingleResponseDTO<EmployeeDTO> response = new SingleResponseDTO<EmployeeDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeDetails(employeeDTO, _options.Value, out exception);
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
        /// Remove Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{id:int}")]
        [Produces("application/json")]
        public IActionResult DeleteEmployeeDetails(int id)
        {
            SingleResponseDTO<string> response = new SingleResponseDTO<string>();
            Exception exception;
            response.Result = _employeeProvider.DeleteEmployeeDetails(id, _options.Value, out exception);
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

        /// <summary>
        /// Get Employee Address By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAddressbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeAddressById(int id)
        {
            SingleResponseDTO<EmployeeAddressDTO> response = new SingleResponseDTO<EmployeeAddressDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeAddressById(id, _options.Value, out exception);
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
        /// Get Employee Address
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllAddress")]
        [Produces("application/json")]
        public IActionResult GetEmployeeAddress()
        {
            MultiResponseDTO<EmployeeAddressDTO> response = new MultiResponseDTO<EmployeeAddressDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeAddress(_options.Value, out exception);
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
        /// Insert Employee Address
        /// </summary>
        /// <param name="employeeAddressDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertAddress")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeAddress([FromBody] EmployeeAddressDTO employeeAddressDTO)
        {
            SingleResponseDTO<EmployeeAddressDTO> response = new SingleResponseDTO<EmployeeAddressDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeAddress(employeeAddressDTO, _options.Value, out exception);
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
        /// Update Employee Address
        /// </summary>
        /// <param name="employeeAddressDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateAddress")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeAddress([FromBody] EmployeeAddressDTO employeeAddressDTO)
        {
            SingleResponseDTO<EmployeeAddressDTO> response = new SingleResponseDTO<EmployeeAddressDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeAddress(employeeAddressDTO, _options.Value, out exception);
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
        /// Get Employee Bank Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBankDetailsbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeebankDetailsById(int id)
        {
            SingleResponseDTO<EmployeeBankDetailsDTO> response = new SingleResponseDTO<EmployeeBankDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeEmployeeBankDetailsById(id, _options.Value, out exception);
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
        /// Get Employee Bank Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllBankDetails")]
        [Produces("application/json")]
        public IActionResult GetEmployeeBankDetails()
        {
            MultiResponseDTO<EmployeeBankDetailsDTO> response = new MultiResponseDTO<EmployeeBankDetailsDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeBankDetails(_options.Value, out exception);
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
        /// Insert Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertBankDetails")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeBankDetails([FromBody] EmployeeBankDetailsDTO employeeBankDetailsDTO)
        {
            SingleResponseDTO<EmployeeBankDetailsDTO> response = new SingleResponseDTO<EmployeeBankDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeBankDetails(employeeBankDetailsDTO, _options.Value, out exception);
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
        /// Update Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateBankDetails")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeBankDetails([FromBody] EmployeeBankDetailsDTO employeeBankDetailsDTO)
        {
            SingleResponseDTO<EmployeeBankDetailsDTO> response = new SingleResponseDTO<EmployeeBankDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeBankDetails(employeeBankDetailsDTO, _options.Value, out exception);
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
