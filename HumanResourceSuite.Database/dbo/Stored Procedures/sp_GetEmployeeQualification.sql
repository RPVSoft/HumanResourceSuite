CREATE PROC [dbo].[sp_GetEmployeeQualification]

AS  
BEGIN  
SET NOCOUNT ON;    

SELECT
 EQ.[id]
,EQ.[employee_id]
,EQ.[emp_code]
,EQ.[qualification_level]
,EQ.[course]
,EQ.[course_ot]
,EQ.[school_university]
,EQ.[marks_percentage]
,EQ.[verified]
,EQ.[created_by]
,EQ.[created_date]
,EQ.[modified_by]
,EQ.[modified_date]
FROM [HumanResourceSuite].[dbo].[EmployeeQualifications] EQ
JOIN Employee E ON EQ.employee_id=E.id
JOIN [Master] M1 ON EQ.qualification_level=M1.id AND M1.master_type_id=9
JOIN [Master] M2 ON EQ.course=M2.id AND M2.master_type_id=10
WHERE E.Active=1
ORDER BY EQ.id DESC

END
