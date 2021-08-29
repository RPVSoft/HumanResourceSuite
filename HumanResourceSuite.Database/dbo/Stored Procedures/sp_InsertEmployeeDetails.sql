CREATE PROC [dbo].[sp_InsertEmployeeDetails]
(
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

INSERT INTO [dbo].[Employee]
           ([emp_code]
           ,[photo_url]
           ,[first_name]
           ,[middle_name]
           ,[last_name]
           ,[gender]
           ,[pan_number]
           ,[marital_status]
           ,[personal_email]
           ,[work_email]
           ,[work_phone]
           ,[phone_ext]
           ,[mobile_no]
           ,[date_of_birth]
           ,[vendor_id]
           ,[active]
           ,[deleted]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
	 (
	@emp_code,
	@photo_url,
	@first_name,
	@middle_name,
	@last_name,
	@gender,
	@pan_number,
	@marital_status,
	@personal_email,
	@work_email,
	@work_phone,
	@phone_ext,
	@mobile_no,
	@date_of_birth,
	@vendor_id,
	@active,
	@deleted,
	@created_by,
	@created_date,
	@modified_by,
	@modified_date
	 )
END