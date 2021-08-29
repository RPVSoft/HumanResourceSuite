CREATE TABLE [dbo].[Master] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [text]           NVARCHAR (50) NOT NULL,
    [master_type_id] TINYINT       NOT NULL,
    CONSTRAINT [PK_Master] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Master_MasterTypes] FOREIGN KEY ([master_type_id]) REFERENCES [dbo].[MasterTypes] ([id])
);

