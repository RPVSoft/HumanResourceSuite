CREATE PROC [dbo].[sp_GetCompanyDetailsById]
(
@CompanyId INT
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT C.[id]
      ,[legal_name]
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
      ,[modified_date]
  FROM [dbo].[Companies] C
JOIN [dbo].[Master] M
ON C.[status]=M.id AND C.industry_type=M.id AND C.company_size=M.id
WHERE C.id=@CompanyId ORDER BY C.id DESC
END