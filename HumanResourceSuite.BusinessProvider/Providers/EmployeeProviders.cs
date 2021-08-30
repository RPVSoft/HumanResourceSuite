using HumanResourceSuite.BusinessProviders.IProviders;
using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using HumanResourceSuite.DataProviders.Configurations;
using HumanResourceSuite.DataProviders.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.Providers
{
   public class EmployeeProviders: BaseProvider,IEmployeeProviders
    {
        private readonly IEmployeeRepository _Employeerepository;
        public EmployeeProviders(IEmployeeRepository Employeerepository)
        {
            _Employeerepository = Employeerepository;
        }

        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeDTO> GetEmployeeDetails(AppSettings settings, out Exception ex)
        {
            List<EmployeeDTO> employeeDTOs = null;
            try
            {
                employeeDTOs = _Employeerepository.GetEmployeeDetails(settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeDTOs;
        }

        /// <summary>
        /// Get Employee Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO GetEmployeeDetailsById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeDTO employeeDTOs = null;
            try
            {
                employeeDTOs = _Employeerepository.GetEmployeeDetailsById(id,settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeDTOs;
        }
        /// <summary>
        /// Insert Empolyee Details
        /// </summary>
        /// <param name="employeeDTOs"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO InsertEmployeeDetails(EmployeeDTO employeeDTOs, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeDTOs = _Employeerepository.InsertEmployeeDetails(employeeDTOs, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeDTOs;
        }

        /// <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employeeDTOs"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO UpdateEmployeeDetails(EmployeeDTO employeeDTOs, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeDTOs = _Employeerepository.UpdateEmployeeDetails(employeeDTOs, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeDTOs;
        }

        /// <summary>
        /// Remove Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public string DeleteEmployeeDetails(int id, AppSettings settings, out Exception ex)
        {
            string result = null;
            try
            {
                result = _Employeerepository.DeleteEmployeeDetails(id, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return result;
        }

        /// <summary>
        /// Get Employee Address
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeAddressDTO> GetEmployeeAddress(AppSettings settings, out Exception ex)
        {
            List<EmployeeAddressDTO> employeeAddressDTOs = null;
            try
            {
                employeeAddressDTOs = _Employeerepository.GetEmployeeAddress(settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeAddressDTOs;
        }

        /// <summary>
        /// Get Employee Address by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO GetEmployeeAddressById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeAddressDTO employeeAddressDTO = null;
            try
            {
                employeeAddressDTO = _Employeerepository.GetEmployeeAddressById(id, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeAddressDTO;
        }

        /// <summary>
        /// Insert Employee Address
        /// </summary>
        /// <param name="employeeaddressDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO InsertEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeaddressDTO = _Employeerepository.InsertEmployeeAddress(employeeaddressDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeaddressDTO;
        }
        /// <summary>
        /// Update Employee Address
        /// </summary>
        /// <param name="employeeaddressDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO UpdateEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeaddressDTO = _Employeerepository.UpdateEmployeeAddress(employeeaddressDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeaddressDTO;
        }

        /// <summary>
        /// Get Employee Bank Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeBankDetailsDTO> GetEmployeeBankDetails(AppSettings settings, out Exception ex)
        {
            List<EmployeeBankDetailsDTO> employeeBankDetailsDTO = null;
            try
            {
                employeeBankDetailsDTO = _Employeerepository.GetEmployeeBankDetails(settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeBankDetailsDTO;
        }

        /// <summary>
        /// Get Employee Bank Details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO GetEmployeeEmployeeBankDetailsById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeBankDetailsDTO employeeBankDetailsDTO = null;
            try
            {
                employeeBankDetailsDTO = _Employeerepository.GetEmployeeEmployeeBankDetailsById(id, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeBankDetailsDTO;
        }

        /// <summary>
        /// Insert Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO InsertEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeBankDetailsDTO = _Employeerepository.InsertEmployeeBankDetails(employeeBankDetailsDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeBankDetailsDTO;
        }
        /// <summary>
        /// Update Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO UpdateEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                employeeBankDetailsDTO = _Employeerepository.UpdateEmployeeBankDetails(employeeBankDetailsDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return employeeBankDetailsDTO;
        }
    }
}
