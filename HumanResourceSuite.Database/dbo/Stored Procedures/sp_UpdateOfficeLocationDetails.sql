CREATE PROC [dbo].[sp_UpdateOfficeLocationDetails]
(
@id int,
@title nvarchar(50)=NULL,
@CountryId int,
@StateId int,
@Address_text nvarchar(max)=NULL,
@CityId int,
@CompanyId int,
@Active int=NULL,
@created_by nvarchar(50),
@created_date datetime,
@modified_by nvarchar(50)= NULL,
@modified_date datetime= NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[OfficeLocations]
SET [title] = @title
,[CountryId] = @CountryId
,[StateId] = @StateId
,[Address_text] = @Address_text
,[CityId] = @CityId
,[CompanyId] = @CompanyId
,[Active]=@Active
,[created_by] = @created_by
,[created_date] = @created_date
,[modified_by] = @modified_by
,[modified_date] = @modified_date
WHERE id=@id
END
