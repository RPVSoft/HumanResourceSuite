CREATE PROC [dbo].[sp_InsertEmployeeQualification]

(
@employee_id int
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

INSERT INTO [dbo].[EmployeeQualifications]
           ([employee_id]
           ,[emp_code]
           ,[qualification_level]
           ,[course]
           ,[course_ot]
           ,[school_university]
           ,[marks_percentage]
           ,[verified]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
(
@employee_id,
@emp_code,
@qualification_level,
@course,
@course_ot,
@school_university,
@marks_percentage,
@verified,
@created_by,
@created_date,
@modified_by,
@modified_date
)

END
