CREATE PROC [dbo].[sp_InsertEmployeeBankDetails]

(
@employee_id int
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

INSERT INTO [dbo].[EmployeeBankDetails]
           ([employee_id]
           ,[emp_code]
           ,[bank]
           ,[account_no]
           ,[ifsc_code]
           ,[active]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
           (
		   @employee_id,
		   @emp_code,
		   @bank,
		   @account_no,
		   @ifsc_code,
		   @active,
		   @created_by,
		   @created_date,
		   @modified_by,
		   @modified_date
		   )

END
