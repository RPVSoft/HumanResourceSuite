CREATE PROC [dbo].[sp_GetEmployeeBankDetailsById]

(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT
 EBD.[id]
,EBD.[employee_id]
,EBD.[emp_code]
,EBD.[bank]
,EBD.[account_no]
,EBD.[ifsc_code]
,EBD.[active]
,EBD.[created_by]
,EBD.[created_date]
,EBD.[modified_by]
,EBD.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmployeeBankDetails] EBD
JOIN Employee E ON EBD.employee_id=E.id
WHERE E.Active=1 AND EBD.id=@id
ORDER BY EBD.id DESC

END
