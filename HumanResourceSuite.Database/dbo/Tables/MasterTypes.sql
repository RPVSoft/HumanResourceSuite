CREATE TABLE [dbo].[MasterTypes] (
    [id]   TINYINT       IDENTITY (1, 1) NOT NULL,
    [text] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MasterTypes] PRIMARY KEY CLUSTERED ([id] ASC)
);

