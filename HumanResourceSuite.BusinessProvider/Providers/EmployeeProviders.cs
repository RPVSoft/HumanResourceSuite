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

    }
}
