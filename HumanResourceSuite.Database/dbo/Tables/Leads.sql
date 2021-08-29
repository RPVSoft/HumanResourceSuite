CREATE TABLE [dbo].[Leads] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [first_name]    NVARCHAR (50)  NOT NULL,
    [last_name]     NVARCHAR (50)  NULL,
    [mobile_no]     NVARCHAR (50)  NOT NULL,
    [email_address] NVARCHAR (50)  NOT NULL,
    [company]       NVARCHAR (100) NOT NULL,
    [industry_type] INT            NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_Leads] PRIMARY KEY CLUSTERED ([Id] ASC)
);

