CREATE TABLE [dbo].[Companies] (
    [id]                 INT            IDENTITY (1, 1) NOT NULL,
    [legal_name]         NVARCHAR (100) NOT NULL,
    [website_url]        NVARCHAR (100) NULL,
    [logo_url]           NVARCHAR (MAX) NULL,
    [status]             INT            NULL,
    [overview]           NVARCHAR (MAX) NULL,
    [industry_type]      INT            NOT NULL,
    [company_size]       INT            NOT NULL,
    [founded_year]       NCHAR (4)      NULL,
    [verified]           BIT            NOT NULL,
    [active]             BIT            NOT NULL,
    [primary_user_email] NVARCHAR (50)  NOT NULL,
    [primary_user_name]  NVARCHAR (50)  NOT NULL,
    [created_by]         NVARCHAR (50)  NULL,
    [created_date]       DATETIME       NOT NULL,
    [modified_by]        NVARCHAR (50)  NULL,
    [modified_date]      DATETIME       NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Companies_Master_CompanySize] FOREIGN KEY ([company_size]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_Companies_Master_Industries_Type] FOREIGN KEY ([industry_type]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_Companies_Master_Status] FOREIGN KEY ([status]) REFERENCES [dbo].[Master] ([id])
);

