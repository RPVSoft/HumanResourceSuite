CREATE PROC [dbo].[sp_GetCompanyDetails]

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
JOIN [dbo].[Master] M1
ON C.[status]=M1.id 
JOIN [dbo].[Master] M2
ON C.industry_type=M2.id
JOIN [dbo].[Master] M3
ON C.company_size=M3.id
WHERE C.active=1
ORDER BY C.id DESC	

END