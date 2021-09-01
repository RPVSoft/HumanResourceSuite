CREATE PROC [dbo].[sp_InsertEmployeeTenureDetails]

(
@employee_id int
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

INSERT INTO [dbo].[EmployeeTenure]
           ([employee_id]
           ,[emp_code]
           ,[from_date]
           ,[to_date]
           ,[reporting_manager]
           ,[department]
           ,[designation]
           ,[role]
           ,[active]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
(
@employee_id,
@emp_code,
@from_date,
@to_date,
@reporting_manager,
@department,
@designation,
@role,
@active,
@created_by,
@created_date,
@modified_by,
@modified_date
)
END
