using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
   public class EmployeeInvestmentDTO
    {
		public int id { get; set; }
		public int employee_id { get; set; }
		public string emp_code { get; set; }
		public string financial_year { get; set; }
		public decimal house_rent_allowance { get; set; }
		public decimal life_insurance_premium { get; set; }
		public decimal provident_fund { get; set; }
		public decimal public_provident_fund { get; set; }
		public decimal voluntary_provident_fund { get; set; }
		public decimal nsc { get; set; }
		public decimal interest_nsc { get; set; }
		public decimal ulip { get; set; }
		public decimal elss_mutual_fund { get; set; }
		public decimal tution_fees { get; set; }
		public decimal principal_repayment_house_loan { get; set; }
		public decimal house_stamp_duty_reg_charges { get; set; }
		public decimal infrastructure_bonds { get; set; }
		public decimal bank_fixed_deposit { get; set; }
		public decimal post_office_term_deposit { get; set; }
		public decimal medical_insurance_premium { get; set; }
		public decimal medical_insurance_premuim_parents { get; set; }
		public decimal preventive_health_checkup { get; set; }
		public decimal home_loan_interest { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }
		public string modified_by { get; set; }
		public DateTime modified_date { get; set; }

	}
}
