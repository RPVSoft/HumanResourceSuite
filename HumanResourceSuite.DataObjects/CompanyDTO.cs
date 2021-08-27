using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class CompanyDTO
    {
        public int id { get; set; }
        public string legal_name { get; set; }
        public string website_url { get; set; }
        public string logo_url { get; set; }
        public int status { get; set; }
        public string overview { get; set; }
        public int industry_type { get; set; }
        public int company_size { get; set; }
        public string founded_year { get; set; }
        public bool verified { get; set; }
        public bool active { get; set; }
        public string primary_user_email { get; set; }
        public string primary_user_name { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_date { get; set; }
    }
}
