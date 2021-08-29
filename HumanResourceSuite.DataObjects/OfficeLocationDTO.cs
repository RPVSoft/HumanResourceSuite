using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class OfficeLocationDTO
    {
		public int id { get; set; }
		public string title { get; set; }
		public int CountryId { get; set; }
		public int StateId { get; set; }
		public string Address_text { get; set; }
		public int CityId { get; set; }
		public int CompanyId { get; set; }
        public bool Active { get; set; }
        public string created_by { get; set; }
		public DateTime created_date { get; set; }
		public string modified_by { get; set; }
		public DateTime modified_date { get; set; }
	}
}
