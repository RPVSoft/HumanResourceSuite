using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class LeadsDTO
    {
		public int Id { get; set; }
		public string First_name { get; set; }
		public string Last_name { get; set; }
		public string Mobile_no { get; set; }
		public string Email_address { get; set; }
		public string Company { get; set; }
		public int Industry_type { get; set; }
		public string Created_by { get; set; }
		public DateTime Created_date { get; set; }
		public string Modified_by { get; set; }
		public DateTime Modified_date { get; set; }
	}
}
