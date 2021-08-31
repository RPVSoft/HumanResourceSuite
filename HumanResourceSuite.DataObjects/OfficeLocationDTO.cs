using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class OfficeLocationDTO : BaseDTO
    {
		public int id { get; set; }
		public string title { get; set; }
		public int CountryId { get; set; }
		public int StateId { get; set; }
		public string Address_text { get; set; }
		public int CityId { get; set; }
		public int CompanyId { get; set; }
        public bool Active { get; set; }       
	}
}
