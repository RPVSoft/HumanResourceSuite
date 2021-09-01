CREATE PROC [dbo].[sp_InsertEmployeeSalaryDetails]

(
@employee_id int
,@emp_code nchar(10)
,@tenure int
,@from_date date=NULL
,@to_date date=NULL
,@financial_year nchar(10)=NULL
,@basic_pay nvarchar(10)=NULL
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)

AS  
BEGIN  
SET NOCOUNT ON;    

INSERT INTO [dbo].[EmployeeSalaryDetails]
           ([employee_id]
           ,[emp_code]
           ,[tenure]
           ,[from_date]
           ,[to_date]
           ,[financial_year]
           ,[basic_pay]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
(
@employee_id,
@emp_code,
@tenure,
@from_date,
@to_date,
@financial_year,
@basic_pay,
@created_by,
@created_date,
@modified_by,
@modified_date
)
END
