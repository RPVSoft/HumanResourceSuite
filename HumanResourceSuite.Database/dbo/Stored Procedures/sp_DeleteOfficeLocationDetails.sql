CREATE PROC [dbo].[sp_DeleteOfficeLocationDetails]
(
@id int,
@Active int
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[OfficeLocations]
SET
[Active]=@Active
WHERE id=@id
END
