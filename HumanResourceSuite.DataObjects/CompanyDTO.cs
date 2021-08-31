using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class CompanyDTO : BaseDTO
    {
        public int Id { get; set; }
        public string Legal_Name { get; set; }
        public string Website_Url { get; set; }
        public string Logo_Url { get; set; }
        public int Status { get; set; }
        public string Overview { get; set; }
        public int Industry_Type { get; set; }
        public int Company_Size { get; set; }
        public string Founded_Year { get; set; }
        public bool Verified { get; set; }
        public bool Active { get; set; }
        public string Primary_User_Email { get; set; }
        public string Primary_User_Name { get; set; }

    }
}
