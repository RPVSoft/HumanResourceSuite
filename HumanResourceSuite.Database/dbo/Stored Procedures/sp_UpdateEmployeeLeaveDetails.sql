create PROC [dbo].[sp_UpdateEmployeeLeaveDetails]

(
 @id int
,@leave_type int
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

UPDATE [dbo].[EmployeeLeave]
   SET [leave_type] = @leave_type
      ,[employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[from_date] = @from_date
      ,[to_date] = @to_date
      ,[reason] = @reason
      ,[status] = @status
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id

END
