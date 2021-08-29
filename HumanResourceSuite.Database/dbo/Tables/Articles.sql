CREATE TABLE [dbo].[Articles] (
    [id]              INT             IDENTITY (1, 1) NOT NULL,
    [title]           NVARCHAR (50)   NULL,
    [description]     NVARCHAR (MAX)  NULL,
    [article_content] VARBINARY (MAX) NULL,
    [created_by]      NVARCHAR (50)   NULL,
    [created_date]    DATETIME        NULL,
    [modified_by]     NVARCHAR (50)   NULL,
    [modified_date]   DATETIME        NULL,
    CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED ([id] ASC)
);

