CREATE PROC [dbo].[sp_GetOfficeLocationDetailsById]
(
@id int
)
AS  
BEGIN  
SET NOCOUNT ON;    

SELECT
 OL.[id]
,OL.[title]
,OL.[CountryId]
,OL.[StateId]
,OL.[Address_text]
,OL.[CityId]
,OL.[Active]
,OL.[CompanyId]
,OL.[created_by]
,OL.[created_date]
,OL.[modified_by]
,OL.[modified_date]
FROM [HumanResourceSuite].[dbo].[OfficeLocations] OL
JOIN Companies C ON OL.CompanyId=C.id
JOIN Countries CS ON OL.CountryId=CS.id
JOIN States S ON OL.StateId=S.id
JOIN Cities CT ON OL.CityId=CT.id
WHERE OL.id=@id 
ORDER BY OL.id DESC

END
