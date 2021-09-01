CREATE PROC [dbo].[sp_UpdateEmployeeSalaryDetails]

(
@id int
,@employee_id int
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

UPDATE [dbo].[EmployeeSalaryDetails]
   SET [employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[tenure] = @tenure
      ,[from_date] = @from_date
      ,[to_date] = @to_date
      ,[financial_year] = @financial_year
      ,[basic_pay] = @basic_pay
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id
 
 END
