CREATE PROC [dbo].[sp_DeleteEmployeeDetails]
(
@EmployeeId int,
@deleted bit
)
AS  
BEGIN  
SET NOCOUNT ON;    

UPDATE [dbo].[Employee]
SET 
[deleted] = @deleted
WHERE id=@EmployeeId

END