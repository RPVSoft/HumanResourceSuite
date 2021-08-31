using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class EmployeeAddressDTO : BaseDTO
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public string Emp_Code { get; set; }
        public string Address_Line { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int Type { get; set; }

    }
}
