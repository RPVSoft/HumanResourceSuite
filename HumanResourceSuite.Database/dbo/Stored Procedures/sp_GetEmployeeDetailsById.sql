CREATE PROC [dbo].[sp_GetEmployeeDetailsById]

(
@EmployeeId INT
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT E.[id]
,[emp_code]
,[photo_url]
,[first_name]
,[middle_name]
,[last_name]
,[gender]
,[pan_number]
,[marital_status]
,[personal_email]
,[work_email]
,[work_phone]
,[phone_ext]
,[mobile_no]
,[date_of_birth]
,[vendor_id]
,[active]
,[deleted]
,[created_by]
,[created_date]
,[modified_by]
,[modified_date]
FROM [HumanResourceSuite].[dbo].[Employee] E
JOIN [HumanResourceSuite].[dbo].[Master] M
ON E.gender=M.id AND E.marital_status=M.id
WHERE E.id=@EmployeeId ORDER BY E.id DESC
END