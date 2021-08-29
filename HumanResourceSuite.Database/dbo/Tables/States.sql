CREATE TABLE [dbo].[States] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [country_id] INT           NOT NULL,
    [text]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_States_Countries] FOREIGN KEY ([country_id]) REFERENCES [dbo].[Countries] ([id])
);

