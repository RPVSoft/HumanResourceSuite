CREATE PROC [dbo].[sp_InsertEmploymentHistory]

(
@employee_id int
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

INSERT INTO [dbo].[EmploymentHistory]
           ([employee_id]
           ,[emp_code]
           ,[employer_name]
           ,[address]
           ,[city]
           ,[state]
           ,[country]
           ,[from_date]
           ,[to_date]
           ,[job_title]
           ,[reason_for_leaving]
           ,[active]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
	 (
	 @employee_id,
	 @emp_code,
	 @employer_name,
	 @address,
	 @city,
	 @state,
	 @country,
	 @from_date,
	 @to_date,
	 @job_title,
	 @reason_for_leaving,
	 @active,
	 @created_by,
	 @created_date,
	 @modified_by,
	 @modified_date
	 )
END
