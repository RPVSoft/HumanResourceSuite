﻿using HumanResourceSuite.Common.Framework;
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
    }
}