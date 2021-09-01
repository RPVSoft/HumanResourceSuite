using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeSalaryDetailsDTO : BaseDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public int tenure { get; set; }
		public DateTime from_date { get; set; }
		public DateTime to_date { get; set; }
		public string financial_year { get; set; }
		public string basic_pay { get; set; }
	}
}
