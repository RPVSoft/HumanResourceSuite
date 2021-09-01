CREATE PROC [dbo].[sp_UpdateEmploymentHistory]
(
@id int
,@employee_id int
,@emp_code nchar(10)=NULL
,@employer_name nvarchar(50)NULL
,@address nvarchar(100)=NULL
,@city int=NULL
,@state int=NULL
,@country int=NULL
,@from_date datetime=NULL
,@to_date datetime=NULL
,@job_title nvarchar(50)=NULL
,@reason_for_leaving nvarchar(max)=NULL
,@active bit
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[EmploymentHistory] SET

 [employee_id] =@employee_id
,[emp_code] = @emp_code
,[employer_name] = @employer_name
,[address] = @address
,[city] = @city
,[state] = @state
,[country] = @country
,[from_date] = @from_date
,[to_date] = @to_date
,[job_title] = @job_title
,[reason_for_leaving] = @reason_for_leaving
,[active] = @active
,[created_by] = @created_by
,[created_date] = @created_date
,[modified_by] = @modified_by
,[modified_date] = @modified_date
 WHERE id=@id


END
