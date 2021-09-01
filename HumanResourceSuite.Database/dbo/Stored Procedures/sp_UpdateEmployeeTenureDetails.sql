CREATE PROC [dbo].[sp_UpdateEmployeeTenureDetails]
(
 @id int
,@employee_id int
,@emp_code nchar(10)
,@from_date date
,@to_date date
,@reporting_manager int=NULL
,@department int=NULL
,@designation int=NULL
,@role int=NULL
,@active bit=NULL
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[EmployeeTenure]
   SET [employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[from_date] = @from_date
      ,[to_date] = @to_date
      ,[reporting_manager] = @reporting_manager
      ,[department] = @department
      ,[designation] = @designation
      ,[role] = @role
      ,[active] = @active
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id

END
