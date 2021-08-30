CREATE PROC [dbo].[sp_UpdateEmployeeBankDetails]

(
@id int
,@employee_id int
,@emp_code nchar(10)
,@bank nvarchar(50)
,@account_no nvarchar(50)
,@ifsc_code nchar(10)
,@active bit=NULL
,@created_by nvarchar(50)=NULL
,@created_date nvarchar(50)=NULL
,@modified_by nvarchar(50)=NULL
,@modified_date nvarchar(50)=NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[EmployeeBankDetails]
   SET [employee_id] = @employee_id
      ,[emp_code] = @emp_code
      ,[bank] = @bank
      ,[account_no] = @account_no
      ,[ifsc_code] = @ifsc_code
      ,[active] = @active
      ,[created_by] = @created_by
      ,[created_date] = @created_date
      ,[modified_by] = @modified_by
      ,[modified_date] = @modified_date
 WHERE id=@id

END
