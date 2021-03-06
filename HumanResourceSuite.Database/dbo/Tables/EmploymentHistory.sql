CREATE TABLE [dbo].[EmploymentHistory] (
    [id]                 INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]        INT            NOT NULL,
    [emp_code]           NCHAR (10)     NULL,
    [employer_name]      NVARCHAR (50)  NULL,
    [address]            NVARCHAR (100) NULL,
    [city]               INT  NULL,
    [state]              INT            NULL,
    [country]            INT            NULL,
    [from_date]          DATETIME       NULL,
    [to_date]            DATETIME       NULL,
    [job_title]          NVARCHAR (50)  NULL,
    [reason_for_leaving] NVARCHAR (MAX) NOT NULL,
    [active]             BIT            NOT NULL,
    [created_by]         NVARCHAR (50)  NOT NULL,
    [created_date]       DATETIME       NOT NULL,
    [modified_by]        NVARCHAR (50)  NULL,
    [modified_date]      DATETIME       NULL,
    CONSTRAINT [PK_EmploymentHistory] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EmploymentHistory_Employee_Id] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmploymentHistory_Master_Country] FOREIGN KEY ([country]) REFERENCES [dbo].[Countries] ([id]),
    CONSTRAINT [FK_EmploymentHistory_Master_State] FOREIGN KEY ([state]) REFERENCES [dbo].[States] ([id]),
    CONSTRAINT [FK_EmploymentHistory_Master_City] FOREIGN KEY ([city]) REFERENCES [dbo].[Cities] ([id])
);

