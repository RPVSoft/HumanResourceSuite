
CREATE PROCEDURE [dbo].[spLeads] 
(  
    @LeadId INT = NULL,  
    @FirstName NVARCHAR(50) = NULL,  
    @LastName NVARCHAR(50) = NULL,  
    @MobileNo NVARCHAR(50) = NULL,  
    @EmailAddress NVARCHAR(50) = NULL,
	@Company NVARCHAR(100)=NULL,
	@IndustryType INT=NULL,
	@CreatedBy NVARCHAR(50)=NULL,  
    @CreatedDate DATETIME=NULL,  
    @UpdatedBy NVARCHAR(50)=NULL,  
    @UpdatedDate DATETIME=NULL,      
    @ActionType VARCHAR(25)  
)  
AS  
BEGIN  
SET NOCOUNT ON;    
       IF @ActionType='Insert'
	   BEGIN  
	   INSERT INTO Leads
	   (
	   first_name,
	   last_name,
	   mobile_no,
	   email_address,
	   company,
	   industry_type,
	   created_by,
	   created_date,
	   modified_by,
	   modified_date
	   )
	   VALUES
	   (
	   @FirstName,
	   @LastName,
	   @MobileNo,
	   @EmailAddress,
	   @Company,
	   @IndustryType,
	   @CreatedBy,
	   @CreatedDate,
	   @UpdatedBy,
	   @UpdatedDate
	   )
    END
	
	IF @ActionType='Fetchall'
	BEGIN
	SELECT * FROM Leads WITH (NOLOCK) ORDER BY Id DESC
	END

	IF @ActionType='FetchbyId'
	BEGIN
	SELECT * FROM Leads WITH (NOLOCK) WHERE Id=@LeadId
	END
END  