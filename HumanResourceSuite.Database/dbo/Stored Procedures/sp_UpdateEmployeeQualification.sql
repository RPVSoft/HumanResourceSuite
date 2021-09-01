CREATE PROC [dbo].[sp_UpdateEmployeeQualification]
(
@id int
,@employee_id int
,@emp_code nchar(10)
,@qualification_level int
,@course int
,@course_ot nvarchar(50)=NULL
,@school_university nvarchar(max)=NULL
,@marks_percentage decimal(18,2)=NULL
,@verified bit=NULL
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[EmployeeQualifications]
   SET [employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[qualification_level] = @qualification_level
      ,[course] = @course
      ,[course_ot] = @course_ot
      ,[school_university] = @school_university
      ,[marks_percentage] = @marks_percentage
      ,[verified] = @verified
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id

END
