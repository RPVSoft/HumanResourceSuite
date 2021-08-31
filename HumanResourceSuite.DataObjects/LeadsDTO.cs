using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class LeadsDTO : BaseDTO
    {
		public int Id { get; set; }
		public string First_name { get; set; }
		public string Last_name { get; set; }
		public string Mobile_no { get; set; }
		public string Email_address { get; set; }
		public string Company { get; set; }
		public int Industry_type { get; set; }		
	}
}
