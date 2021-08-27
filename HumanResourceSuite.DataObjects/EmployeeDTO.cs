using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string emp_code { get; set; }
        public string photo_url { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public int gender { get; set; }
        public string pan_number { get; set; }
        public int marital_status { get; set; }
        public string personal_email { get; set; }
        public string work_email { get; set; }
        public string work_phone { get; set; }
        public string phone_ext { get; set; }
        public string mobile_no { get; set; }
        public DateTime date_of_birth { get; set; }
        public int vendor_id { get; set; }
        public bool active { get; set; }
        public bool deleted { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_date { get; set; }
    }
}
