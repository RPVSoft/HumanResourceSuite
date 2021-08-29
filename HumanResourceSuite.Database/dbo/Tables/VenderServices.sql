CREATE TABLE [dbo].[VenderServices] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [vendor_id]     INT           NOT NULL,
    [service_type]  INT           NOT NULL,
    [created_by]    NVARCHAR (50) NOT NULL,
    [created_date]  DATETIME      NOT NULL,
    [modified_by]   NVARCHAR (50) NULL,
    [modified_date] DATETIME      NULL,
    CONSTRAINT [PK_VenderServices] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_VenderServices_Master] FOREIGN KEY ([service_type]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_VenderServices_Vendors] FOREIGN KEY ([vendor_id]) REFERENCES [dbo].[Vendors] ([id])
);

