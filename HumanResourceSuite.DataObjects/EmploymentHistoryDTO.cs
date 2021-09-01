using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmploymentHistoryDTO : BaseDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public string employer_name { get; set; }
		public string address { get; set; }
		public int city { get; set; }
		public int state { get; set; }
		public int country { get; set; }
		public DateTime from_date { get; set; }
		public DateTime to_date { get; set; }
		public string job_title { get; set; }
		public string reason_for_leaving { get; set; }
		public bool active { get; set; }
	}
}
