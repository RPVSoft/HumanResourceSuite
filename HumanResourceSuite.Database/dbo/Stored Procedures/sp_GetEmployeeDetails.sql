CREATE PROC [dbo].[sp_GetEmployeeDetails]

AS  
BEGIN  
SET NOCOUNT ON;    

SELECT E.[id]
,E.[emp_code]
,E.[photo_url]
,E.[first_name]
,E.[middle_name]
,E.[last_name]
,E.[gender]
,E.[pan_number]
,E.[marital_status]
,E.[personal_email]
,E.[work_email]
,E.[work_phone]
,E.[phone_ext]
,E.[mobile_no]
,E.[date_of_birth]
,E.[vendor_id]
,E.[active]
,E.[deleted]
,E.[created_by]
,E.[created_date]
,E.[modified_by]
,E.[modified_date]
FROM [HumanResourceSuite].[dbo].[Employee] E
JOIN [HumanResourceSuite].[dbo].[Master] M1
ON E.gender=M1.id
JOIN [HumanResourceSuite].[dbo].[Master] M2
ON E.marital_status=M2.id
WHERE E.active=1
ORDER BY E.id DESC

END