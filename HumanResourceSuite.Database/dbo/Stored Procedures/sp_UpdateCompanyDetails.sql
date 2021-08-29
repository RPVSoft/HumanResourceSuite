CREATE PROC sp_UpdateCompanyDetails
(
@CompanyId int,
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

UPDATE [dbo].[Companies]
SET [legal_name] = @legal_name
,[website_url] = @website_url
,[logo_url] = @logo_url
,[status] = @status
,[overview] = @overview
,[industry_type] = @industry_type
,[company_size] = @company_size
,[founded_year] = @founded_year
,[verified] = @verified
,[active] = @active
,[primary_user_email] = @primary_user_email
,[primary_user_name] = @primary_user_name
,[created_by] = @created_by
,[created_date] = @created_date
,[modified_by] = @modified_by
,[modified_date] = @modified_date
 WHERE id=@CompanyId

END