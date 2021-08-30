CREATE PROC [dbo].[sp_UpdateEmployeeAddressDetails]
(
@id int,
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

UPDATE [dbo].[EmployeeAddress]
   SET [employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[address_line] = @address_line
      ,[city] = @city
      ,[state] = @state
      ,[country] = @country
      ,[type] = @type
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id

END
