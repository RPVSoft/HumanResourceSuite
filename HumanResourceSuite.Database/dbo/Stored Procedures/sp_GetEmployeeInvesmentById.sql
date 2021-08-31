CREATE PROC [dbo].[sp_GetEmployeeInvesmentById]

(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT
 EID.[id]
,EID.[employee_id]
,EID.[emp_code]
,EID.[financial_year]
,EID.[house_rent_allowance]
,EID.[life_insurance_premium]
,EID.[provident_fund]
,EID.[public_provident_fund]
,EID.[voluntary_provident_fund]
,EID.[nsc]
,EID.[interest_nsc]
,EID.[ulip]
,EID.[elss_mutual_fund]
,EID.[tution_fees]
,EID.[principal_repayment_house_loan]
,EID.[house_stamp_duty_reg_charges]
,EID.[infrastructure_bonds]
,EID.[bank_fixed_deposit]
,EID.[post_office_term_deposit]
,EID.[medical_insurance_premium]
,EID.[medical_insurance_premuim_parents]
,EID.[preventive_health_checkup]
,EID.[home_loan_interest]
,EID.[created_by]
,EID.[created_date]
,EID.[modified_by]
,EID.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmployeeInvestmentDetails] EID
JOIN Employee E ON EID.employee_id=E.id
WHERE E.Active=1 AND EID.id=@id
ORDER BY EID.id DESC

END
