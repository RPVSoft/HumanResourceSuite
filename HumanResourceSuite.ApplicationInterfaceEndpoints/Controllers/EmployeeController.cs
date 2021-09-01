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

        /// <summary>
        /// Get Employee Investment Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetInvestmentbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeEmployeeInvestmentById(int id)
        {
            SingleResponseDTO<EmployeeInvestmentDTO> response = new SingleResponseDTO<EmployeeInvestmentDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeEmployeeInvestmentById(id, _options.Value, out exception);
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
        /// Get Employee Investment Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllInvestment")]
        [Produces("application/json")]
        public IActionResult GetEmployeeInvestment()
        {
            MultiResponseDTO<EmployeeInvestmentDTO> response = new MultiResponseDTO<EmployeeInvestmentDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeInvestment(_options.Value, out exception);
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
        /// Insert Employee Investment Details
        /// </summary>
        /// <param name="employeeInvestmentDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertInvestment")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeInvestment([FromBody] EmployeeInvestmentDTO employeeInvestmentDTO)
        {
            SingleResponseDTO<EmployeeInvestmentDTO> response = new SingleResponseDTO<EmployeeInvestmentDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeInvestment(employeeInvestmentDTO, _options.Value, out exception);
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
        /// Update Employee Investment Details
        /// </summary>
        /// <param name="employeeInvestmentDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateInvestment")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeInvestment([FromBody] EmployeeInvestmentDTO employeeInvestmentDTO)
        {
            SingleResponseDTO<EmployeeInvestmentDTO> response = new SingleResponseDTO<EmployeeInvestmentDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeInvestment(employeeInvestmentDTO, _options.Value, out exception);
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
        /// Get Employee Leave Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLeaveDetailsbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeLeaveDetailsById(int id)
        {
            SingleResponseDTO<EmployeeLeaveDTO> response = new SingleResponseDTO<EmployeeLeaveDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeLeaveDetailsById(id, _options.Value, out exception);
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
        /// Get Employee Leave Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllLeaveDetails")]
        [Produces("application/json")]
        public IActionResult GetEmployeeLeaveDetails()
        {
            MultiResponseDTO<EmployeeLeaveDTO> response = new MultiResponseDTO<EmployeeLeaveDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeLeaveDetails(_options.Value, out exception);
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
        /// Insert Employee Leave Details
        /// </summary>
        /// <param name="employeeLeaveDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertLeaveDetails")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeLeaveDetails([FromBody] EmployeeLeaveDTO employeeLeaveDTO)
        {
            SingleResponseDTO<EmployeeLeaveDTO> response = new SingleResponseDTO<EmployeeLeaveDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeLeaveDetails(employeeLeaveDTO, _options.Value, out exception);
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
        /// Update Employee Leave Details
        /// </summary>
        /// <param name="employeeLeaveDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateLeaveDetails")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeLeaveDetails([FromBody] EmployeeLeaveDTO employeeLeaveDTO)
        {
            SingleResponseDTO<EmployeeLeaveDTO> response = new SingleResponseDTO<EmployeeLeaveDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeLeaveDetails(employeeLeaveDTO, _options.Value, out exception);
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
        /// Get Employee Qualification Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetQualificationbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeQualificationById(int id)
        {
            SingleResponseDTO<EmployeeQualificationDTO> response = new SingleResponseDTO<EmployeeQualificationDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeQualificationById(id, _options.Value, out exception);
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
        /// Get Employee Leave Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllQualificationDetails")]
        [Produces("application/json")]
        public IActionResult GetEmployeeQualification()
        {
            MultiResponseDTO<EmployeeQualificationDTO> response = new MultiResponseDTO<EmployeeQualificationDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeQualification(_options.Value, out exception);
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
        /// Insert Employee Qualification Details
        /// </summary>
        /// <param name="employeeQualificationDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertQualificationDetails")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeQualification([FromBody] EmployeeQualificationDTO employeeQualificationDTO)
        {
            SingleResponseDTO<EmployeeQualificationDTO> response = new SingleResponseDTO<EmployeeQualificationDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeQualification(employeeQualificationDTO, _options.Value, out exception);
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
        /// Update Employee Leave Details
        /// </summary>
        /// <param name="employeeQualificationDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateQualificationDetails")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeQualification([FromBody] EmployeeQualificationDTO employeeQualificationDTO)
        {
            SingleResponseDTO<EmployeeQualificationDTO> response = new SingleResponseDTO<EmployeeQualificationDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeQualification(employeeQualificationDTO, _options.Value, out exception);
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
        /// Get Employee Salary Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSalaryDetailsbyId/{id:int}")]
        [Produces("application/json")]
        public IActionResult GetEmployeeSalaryDetailsById(int id)
        {
            SingleResponseDTO<EmployeeSalaryDetailsDTO> response = new SingleResponseDTO<EmployeeSalaryDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.GetEmployeeSalaryDetailsById(id, _options.Value, out exception);
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
        /// Get Employee Salary Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllSalaryDetails")]
        [Produces("application/json")]
        public IActionResult GetEmployeeSalaryDetails()
        {
            MultiResponseDTO<EmployeeSalaryDetailsDTO> response = new MultiResponseDTO<EmployeeSalaryDetailsDTO>();
            Exception exception;
            response.Data = _employeeProvider.GetEmployeeSalaryDetails(_options.Value, out exception);
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
        /// <param name="employeeSalaryDetailsDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertSalaryDetails")]
        [Produces("application/json")]
        public IActionResult InsertEmployeeSalaryDetails([FromBody] EmployeeSalaryDetailsDTO employeeSalaryDetailsDTO)
        {
            SingleResponseDTO<EmployeeSalaryDetailsDTO> response = new SingleResponseDTO<EmployeeSalaryDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.InsertEmployeeSalaryDetails(employeeSalaryDetailsDTO, _options.Value, out exception);
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
        /// Update Employee Salary Details
        /// </summary>
        /// <param name="employeeSalaryDetailsDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateSalaryDetails")]
        [Produces("application/json")]
        public IActionResult UpdateEmployeeSalaryDetails([FromBody] EmployeeSalaryDetailsDTO employeeSalaryDetailsDTO)
        {
            SingleResponseDTO<EmployeeSalaryDetailsDTO> response = new SingleResponseDTO<EmployeeSalaryDetailsDTO>();
            Exception exception;
            response.Result = _employeeProvider.UpdateEmployeeSalaryDetails(employeeSalaryDetailsDTO, _options.Value, out exception);
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
