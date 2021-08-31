CREATE PROC [dbo].[sp_InsertEmployeeLeaveDetails]

(
 @leave_type int
,@employee_id int
,@emp_code nchar(10)
,@from_date datetime
,@to_date datetime
,@reason nvarchar(max)
,@status int
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

INSERT INTO [dbo].[EmployeeLeave]
           ([leave_type]
           ,[employee_id]
           ,[emp_code]
           ,[from_date]
           ,[to_date]
           ,[reason]
           ,[status]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])

		   VALUES
		   (
		   @leave_type,
		   @employee_id,
		   @emp_code,
		   @from_date,
		   @to_date,
		   @reason,
		   @status,
		   @created_by,
		   @created_date,
		   @modified_by,
		   @modified_date
		   )

END
