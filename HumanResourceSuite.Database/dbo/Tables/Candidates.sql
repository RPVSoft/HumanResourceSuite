CREATE TABLE [dbo].[Candidates] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [photo_url]      NVARCHAR (MAX) NULL,
    [first_name]     NVARCHAR (50)  NOT NULL,
    [middle_name]    NVARCHAR (50)  NULL,
    [last_name]      NVARCHAR (50)  NULL,
    [gender]         INT            NOT NULL,
    [pan_number]     NCHAR (10)     NULL,
    [marital_status] INT            NOT NULL,
    [personal_email] NVARCHAR (50)  NULL,
    [mobile_no]      NCHAR (10)     NULL,
    [date_of_birth]  DATE           NULL,
    [vendor_id]      INT            NOT NULL,
    [active]         BIT            NULL,
    [deleted]        BIT            NULL,
    [created_by]     NVARCHAR (50)  NOT NULL,
    [created_date]   DATETIME       NOT NULL,
    [modified_by]    NVARCHAR (50)  NULL,
    [modified_date]  DATETIME       NULL,
    CONSTRAINT [PK_Candidates] PRIMARY KEY CLUSTERED ([id] ASC)
);

