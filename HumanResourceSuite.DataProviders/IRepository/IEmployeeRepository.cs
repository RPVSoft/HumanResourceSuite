using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataProviders.IRepository
{
   public interface IEmployeeRepository
    {
        public List<EmployeeDTO> GetEmployeeDetails(AppSettings settings, out Exception ex);
        public EmployeeDTO GetEmployeeDetailsById(int id, AppSettings settings, out Exception ex);
        public EmployeeDTO InsertEmployeeDetails(EmployeeDTO employeeDTO, AppSettings settings, out Exception ex);
        public EmployeeDTO UpdateEmployeeDetails(EmployeeDTO employeeDTO, AppSettings settings, out Exception ex);
        public string DeleteEmployeeDetails(int id, AppSettings settings, out Exception ex);

        // Employee Address
        public List<EmployeeAddressDTO> GetEmployeeAddress(AppSettings settings, out Exception ex);
        public EmployeeAddressDTO GetEmployeeAddressById(int id, AppSettings settings, out Exception ex);
        public EmployeeAddressDTO InsertEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex);
        public EmployeeAddressDTO UpdateEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex);

    }
}
