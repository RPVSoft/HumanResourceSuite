using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.IProviders
{
   public interface IEmployeeProviders
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

        // Employee Bank Details
        public List<EmployeeBankDetailsDTO> GetEmployeeBankDetails(AppSettings settings, out Exception ex);
        public EmployeeBankDetailsDTO GetEmployeeEmployeeBankDetailsById(int id, AppSettings settings, out Exception ex);
        public EmployeeBankDetailsDTO InsertEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex);
        public EmployeeBankDetailsDTO UpdateEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex);

        // Employee Investment
        public List<EmployeeInvestmentDTO> GetEmployeeInvestment(AppSettings settings, out Exception ex);
        public EmployeeInvestmentDTO GetEmployeeEmployeeInvestmentById(int id, AppSettings settings, out Exception ex);
        public EmployeeInvestmentDTO InsertEmployeeInvestment(EmployeeInvestmentDTO employeeInvestmentDTO, AppSettings settings, out Exception ex);
        public EmployeeInvestmentDTO UpdateEmployeeInvestment(EmployeeInvestmentDTO employeeInvestmentDTO, AppSettings settings, out Exception ex);


        // Employee Leave
        public List<EmployeeLeaveDTO> GetEmployeeLeaveDetails(AppSettings settings, out Exception ex);
        public EmployeeLeaveDTO GetEmployeeLeaveDetailsById(int id, AppSettings settings, out Exception ex);
        public EmployeeLeaveDTO InsertEmployeeLeaveDetails(EmployeeLeaveDTO employeeLeaveDTO, AppSettings settings, out Exception ex);
        public EmployeeLeaveDTO UpdateEmployeeLeaveDetails(EmployeeLeaveDTO employeeLeaveDTO, AppSettings settings, out Exception ex);

        // Employee Qualification
        public List<EmployeeQualificationDTO> GetEmployeeQualification(AppSettings settings, out Exception ex);
        public EmployeeQualificationDTO GetEmployeeQualificationById(int id, AppSettings settings, out Exception ex);
        public EmployeeQualificationDTO InsertEmployeeQualification(EmployeeQualificationDTO employeeQualificationDTO, AppSettings settings, out Exception ex);
        public EmployeeQualificationDTO UpdateEmployeeQualification(EmployeeQualificationDTO employeeQualificationDTO, AppSettings settings, out Exception ex);

        // Employee Salary
        public List<EmployeeSalaryDetailsDTO> GetEmployeeSalaryDetails(AppSettings settings, out Exception ex);
        public EmployeeSalaryDetailsDTO GetEmployeeSalaryDetailsById(int id, AppSettings settings, out Exception ex);
        public EmployeeSalaryDetailsDTO InsertEmployeeSalaryDetails(EmployeeSalaryDetailsDTO employeeSalaryDetailsDTO, AppSettings settings, out Exception ex);
        public EmployeeSalaryDetailsDTO UpdateEmployeeSalaryDetails(EmployeeSalaryDetailsDTO employeeSalaryDetailsDTO, AppSettings settings, out Exception ex);

    }
}
