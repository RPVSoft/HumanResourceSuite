using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeQualificationDTO : BaseDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public int qualification_level { get; set; }
		public int course { get; set; }
		public string course_ot { get; set; }
		public string school_university { get; set; }
		public decimal marks_percentage { get; set; }
		public bool verified { get; set; }
	}
}
