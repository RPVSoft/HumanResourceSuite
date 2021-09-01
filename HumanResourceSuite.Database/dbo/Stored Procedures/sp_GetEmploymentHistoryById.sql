CREATE PROC [dbo].[sp_GetEmploymentHistoryById]

(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT 
 EH.[id]
,EH.[employee_id]
,EH.[emp_code]
,EH.[employer_name]
,EH.[address]
,EH.[city]
,EH.[state]
,EH.[country]
,EH.[from_date]
,EH.[to_date]
,EH.[job_title]
,EH.[reason_for_leaving]
,EH.[active]
,EH.[created_by]
,EH.[created_date]
,EH.[modified_by]
,EH.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmploymentHistory] EH
JOIN Employee E ON EH.employee_id=E.id
JOIN Countries CS ON EH.country=CS.id
JOIN States S ON EH.[state]=S.id
JOIN Cities CT ON EH.city=CT.id
WHERE EH.id=@id
ORDER BY EH.id DESC

END
