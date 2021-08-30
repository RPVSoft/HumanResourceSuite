CREATE PROC [dbo].[sp_InsertEmployeeAddressDetails]
(
 @employee_id int
,@emp_code nchar(10)
,@address_line nvarchar(max)
,@city int
,@state int
,@country int
,@type int
,@created_by nvarchar(50)
,@created_date datetime
,@modified_by nvarchar(50)=NULL
,@modified_date datetime=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

INSERT INTO [dbo].[EmployeeAddress]
           ([employee_id]
           ,[emp_code]
           ,[address_line]
           ,[city]
           ,[state]
           ,[country]
           ,[type]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])

     VALUES
	 (
@employee_id,
@emp_code,
@address_line,
@city,
@state,
@country,
@type,
@created_by,
@created_date,
@modified_by,
@modified_date
	 )
END
