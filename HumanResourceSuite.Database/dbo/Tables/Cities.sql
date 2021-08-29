CREATE TABLE [dbo].[Cities] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [state_id] INT           NOT NULL,
    [text]     NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Cities_States] FOREIGN KEY ([state_id]) REFERENCES [dbo].[States] ([id])
);

