CREATE TABLE [dbo].[OfficeLocations] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [title]         NVARCHAR (50)  NULL,
    [CountryId]     INT            NOT NULL,
    [StateId]       INT            NOT NULL,
    [Address_text]  NVARCHAR (MAX) NULL,
    [CityId]        INT            NOT NULL,
    [Active]        BIT            NULL,
    [CompanyId]     INT            NOT NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_OfficeLocations] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_OfficeLocations_Cities] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([id]),
    CONSTRAINT [FK_OfficeLocations_Companies] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([id]),
    CONSTRAINT [FK_OfficeLocations_Countries] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([id]),
    CONSTRAINT [FK_OfficeLocations_States] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States] ([id])
);

