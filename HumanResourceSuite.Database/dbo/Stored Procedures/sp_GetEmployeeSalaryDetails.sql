CREATE PROC [dbo].[sp_GetEmployeeSalaryDetails]

AS  
BEGIN  
SET NOCOUNT ON;    

SELECT 
 ESD.[id]
,ESD.[employee_id]
,ESD.[emp_code]
,ESD.[tenure]
,ESD.[from_date]
,ESD.[to_date]
,ESD.[financial_year]
,ESD.[basic_pay]
,ESD.[created_by]
,ESD.[created_date]
,ESD.[modified_by]
,ESD.[modified_date]
  FROM [HumanResourceSuite].[dbo].[EmployeeSalaryDetails] ESD
JOIN Employee E ON ESD.employee_id=E.id
WHERE E.Active=1
ORDER BY ESD.id DESC

END
