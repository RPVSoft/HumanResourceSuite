using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceSuite.WebFront.Constants
{
    public struct RequestURI
    {
        public const string MasterGetAll = "api/master/getall";
        public const string MasterGet = "api/master/get/{0}";
        public const string MasterInsert = "api/master/insert";

        public const string LeadsGetAll = "api/Leads/GetAll";
        public const string LeadsGet = "api/Leads/GetById/{0}";
        public const string LeadsInsert = "api/Leads/Insert";

        public const string EmployeeGetAll = "api/Employee/GetAll";
        public const string EmployeeGet = "api/Employee/GetById/{0}";
        public const string EmployeeInsert = "api/Employee/Insert";

        public const string CompanyGetAll = "api/Company/GetAll";
        public const string CompanyGet = "api/Company/GetById/{0}";
        public const string CompanyInsert = "api/Company/Insert";
    }
}
