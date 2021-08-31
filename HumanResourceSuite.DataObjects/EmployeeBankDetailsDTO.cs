using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeBankDetailsDTO : BaseDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public string bank { get; set; }
		public string account_no { get; set; }
		public string ifsc_code { get; set; }
		public bool active { get; set; }
		
	}
}
