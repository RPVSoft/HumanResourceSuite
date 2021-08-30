using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeAddressDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public string address_line { get; set; }
		public int city { get; set; }
		public int state { get; set; }
		public int country { get; set; }
		public int type { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }
		public string modified_by { get; set; }
		public DateTime modified_date { get; set; }
	}
}
