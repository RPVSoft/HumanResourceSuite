using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeLeaveDTO : BaseDTO
    {
		public int id { get; set; }
		public int leave_type { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public DateTime from_date { get; set; }
		public DateTime to_date { get; set; }
		public string reason { get; set; }
		public int status { get; set; }
	}
}
