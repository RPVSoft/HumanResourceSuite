CREATE PROC sp_InsertCompanyDetails
(
@legal_name nvarchar(100),
@website_url nvarchar(100)= NULL,
@logo_url nvarchar(max)= NULL,
@status int= NULL,
@overview nvarchar(max)= NULL,
@industry_type int,
@company_size int,
@founded_year nchar(4)= NULL,
@verified bit,
@active bit,
@primary_user_email nvarchar(50),
@primary_user_name nvarchar(50),
@created_by nvarchar(50),
@created_date datetime,
@modified_by nvarchar(50)= NULL,
@modified_date datetime= NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

INSERT INTO [dbo].[Companies]
           ([legal_name]
           ,[website_url]
           ,[logo_url]
           ,[status]
           ,[overview]
           ,[industry_type]
           ,[company_size]
           ,[founded_year]
           ,[verified]
           ,[active]
           ,[primary_user_email]
           ,[primary_user_name]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])
     VALUES
	 (
	 @legal_name,
	 @website_url,
	 @logo_url,
	 @status,
	 @overview,
	 @industry_type,
	 @company_size,
	 @founded_year,
	 @verified,
	 @active,
	 @primary_user_email,
	 @primary_user_name,
	 @created_by,
	 @created_date,
	 @modified_by,
	 @modified_date
	 )
END