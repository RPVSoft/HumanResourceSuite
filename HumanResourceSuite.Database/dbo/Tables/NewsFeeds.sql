CREATE TABLE [dbo].[NewsFeeds] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [title]         NVARCHAR (200) NOT NULL,
    [description]   NVARCHAR (MAX) NOT NULL,
    [employee_id]   INT            NOT NULL,
    [emp_code]      NCHAR (10)     NOT NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_NewsFeeds] PRIMARY KEY CLUSTERED ([id] ASC)
);

