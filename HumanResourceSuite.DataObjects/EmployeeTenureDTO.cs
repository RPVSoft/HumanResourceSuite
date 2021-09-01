using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeTenureDTO : BaseDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public DateTime from_date { get; set; }
		public DateTime to_date { get; set; }
		public int reporting_manager { get; set; }
		public int department { get; set; }
		public int designation { get; set; }
		public int role { get; set; }
		public bool active { get; set; }
	}
}
