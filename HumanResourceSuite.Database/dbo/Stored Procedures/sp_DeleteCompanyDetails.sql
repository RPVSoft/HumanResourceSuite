CREATE PROC sp_DeleteCompanyDetails
(
@CompanyId int,
@active bit
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[Companies]
SET 
[active] = @active
WHERE id=@CompanyId

END