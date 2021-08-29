CREATE PROC [dbo].[sp_InsertOfficeLocationDetails]
(
@title nvarchar(50)=NULL,
@CountryId int,
@StateId int,
@Address_text nvarchar(max)=NULL,
@CityId int,
@CompanyId int,
@Active int,
@created_by nvarchar(50),
@created_date datetime,
@modified_by nvarchar(50)= NULL,
@modified_date datetime= NULL
)
AS  
BEGIN  
SET NOCOUNT ON;    

INSERT INTO [dbo].[OfficeLocations]
           ([title]
           ,[CountryId]
           ,[StateId]
           ,[Address_text]
           ,[CityId]
           ,[CompanyId]
		   ,[Active]
           ,[created_by]
           ,[created_date]
           ,[modified_by]
           ,[modified_date])

     VALUES
	 (
@title
,@CountryId
,@StateId
,@Address_text
,@CityId
,@CompanyId
,@Active
,@created_by
,@created_date
,@modified_by
,@modified_date
	 )
END
