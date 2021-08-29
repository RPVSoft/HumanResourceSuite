CREATE PROC [dbo].[sp_UpdateEmployeeDetails]
(
@EmployeeId int,
@emp_code nvarchar(10),
@photo_url nvarchar(max)= NULL,
@first_name nvarchar(50),
@middle_name nvarchar(50)= NULL,
@last_name nvarchar(50)= NULL,
@gender int,
@pan_number nchar(10)=NULL,
@marital_status int,
@personal_email nvarchar(50)=NULL,
@work_email nvarchar(50)=NULL,
@work_phone nchar(10)=NULL,
@phone_ext nchar(5)=NULL,
@mobile_no nchar(10)=NULL,
@date_of_birth date=NULL,
@vendor_id int,
@active bit=null,
@deleted bit=NULL,
@created_by nvarchar(50),
@created_date datetime,
@modified_by nvarchar(50)= NULL,
@modified_date datetime= NULL
)

AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[Employee]
SET [emp_code] = @emp_code
,[photo_url] = @photo_url
,[first_name] = @first_name
,[middle_name] = @middle_name
,[last_name] = @last_name
,[gender] = @gender
,[pan_number] = @pan_number
,[marital_status] = @marital_status
,[personal_email] = @personal_email
,[work_email] = @work_email
,[work_phone] = @work_phone
,[phone_ext] = @phone_ext
,[mobile_no] = @mobile_no
,[date_of_birth] = @date_of_birth
,[vendor_id] = @vendor_id
,[active] = @active
,[deleted] = @deleted
,[created_by] = @created_by
,[created_date] = @created_date
,[modified_by] = @modified_by
,[modified_date] = @modified_date
 WHERE id=@EmployeeId

END