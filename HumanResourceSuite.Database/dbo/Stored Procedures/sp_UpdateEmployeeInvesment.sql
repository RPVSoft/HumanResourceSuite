CREATE PROC [dbo].[sp_UpdateEmployeeInvesment]

(
 @id int
,@employee_id int
,@emp_code nchar(10)
,@financial_year nchar(10)=NULL
,@house_rent_allowance decimal(18,2)=NULL
,@life_insurance_premium decimal(18,2)=NULL
,@provident_fund decimal(18,2)=NULL
,@public_provident_fund decimal(18,2)=NULL
,@voluntary_provident_fund decimal(18,2)=NULL
,@nsc decimal(18,2)=NULL
,@interest_nsc decimal(18,2)=NULL
,@ulip decimal(18,2)=NULL
,@elss_mutual_fund decimal(18,2)=NULL
,@tution_fees decimal(18,2)=NULL
,@principal_repayment_house_loan decimal(18,2)=NULL
,@house_stamp_duty_reg_charges decimal(18,2)=NULL
,@infrastructure_bonds decimal(18,2)=NULL
,@bank_fixed_deposit decimal(18,2)=NULL
,@post_office_term_deposit decimal(18,2)=NULL
,@medical_insurance_premium decimal(18,2)=NULL
,@medical_insurance_premuim_parents decimal(18,2)=NULL
,@preventive_health_checkup decimal(18,2)=NULL
,@home_loan_interest decimal(18,2)=NULL
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[EmployeeInvestmentDetails]
SET [employee_id] = @employee_id
,[emp_code] = @emp_code
,[financial_year] = @financial_year
,[house_rent_allowance] = @house_rent_allowance
,[life_insurance_premium] = @life_insurance_premium
,[provident_fund] = @provident_fund
,[public_provident_fund] = @public_provident_fund
,[voluntary_provident_fund] = @voluntary_provident_fund
,[nsc] = @nsc
,[interest_nsc] = @interest_nsc
,[ulip] = @ulip
,[elss_mutual_fund] = @elss_mutual_fund
,[tution_fees] = @tution_fees
,[principal_repayment_house_loan] = @principal_repayment_house_loan
,[house_stamp_duty_reg_charges] = @house_stamp_duty_reg_charges
,[infrastructure_bonds] = @infrastructure_bonds
,[bank_fixed_deposit] = @bank_fixed_deposit
,[post_office_term_deposit] = @post_office_term_deposit
,[medical_insurance_premium] = @medical_insurance_premium
,[medical_insurance_premuim_parents] = @medical_insurance_premuim_parents
,[preventive_health_checkup] = @preventive_health_checkup
,[home_loan_interest] = @home_loan_interest
,[created_by] = @created_by
,[created_date] = @created_date
,[modified_by] = @modified_by
,[modified_date] = @modified_date
 WHERE id=@id


END
