CREATE PROC [dbo].[sp_GetEmployeeLeaveDetails]

AS  
BEGIN  
SET NOCOUNT ON;    

SELECT 
 EL.[id]
,EL.[leave_type]
,EL.[employee_id]
,EL.[emp_code]
,EL.[from_date]
,EL.[to_date]
,EL.[reason]
,EL.[status]
,EL.[created_by]
,EL.[created_date]
,EL.[modified_by]
,EL.[modified_date]
  FROM [HumanResourceSuite].[dbo].[EmployeeLeave] EL
JOIN Employee E ON EL.employee_id=E.id
JOIN [Master] M1 ON EL.[status]=M1.id AND M1.master_type_id=7
JOIN [Master] M2 ON EL.[leave_type]=M2.id AND M2.master_type_id=8
WHERE E.Active=1
ORDER BY EL.id DESC

END
