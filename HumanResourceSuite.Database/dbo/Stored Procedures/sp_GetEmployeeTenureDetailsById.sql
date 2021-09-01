CREATE PROC [dbo].[sp_GetEmployeeTenureDetailsById]

(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT 
 ET.[id]
,ET.[employee_id]
,ET.[emp_code]
,ET.[from_date]
,ET.[to_date]
,ET.[reporting_manager]
,ET.[department]
,ET.[designation]
,ET.[role]
,ET.[active]
,ET.[created_by]
,ET.[created_date]
,ET.[modified_by]
,ET.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmployeeTenure] ET
JOIN Employee E1 ON ET.employee_id=E1.id
JOIN Employee E2 ON ET.reporting_manager=E2.id
JOIN [Master] M1 ON ET.department=M1.id AND M1.master_type_id=11
JOIN [Master] M2 ON ET.designation=M2.id AND M2.master_type_id=12
WHERE E1.Active=1 AND ET.id=@id
ORDER BY ET.id DESC

END
