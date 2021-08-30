CREATE PROC [dbo].[sp_GetEmployeeAddressDetailsById]

(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT
 EA.[id]
,EA.[employee_id]
,EA.[emp_code]
,EA.[address_line]
,EA.[city]
,EA.[state]
,EA.[country]
,EA.[type]
,EA.[created_by]
,EA.[created_date]
,EA.[modified_by]
,EA.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmployeeAddress] EA
JOIN Employee E ON EA.employee_id=E.id
JOIN Countries CS ON EA.country=CS.id
JOIN States S ON EA.[state]=S.id
JOIN Cities CT ON EA.city=CT.id
JOIN [Master] M ON EA.[type]=M.id
WHERE E.Active=1 AND EA.id=@id
ORDER BY EA.id DESC

END
