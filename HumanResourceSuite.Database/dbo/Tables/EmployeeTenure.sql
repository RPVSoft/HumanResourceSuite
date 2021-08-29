CREATE TABLE [dbo].[EmployeeTenure] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]       INT           NOT NULL,
    [emp_code]          NCHAR (10)    NULL,
    [from_date]         DATE          NOT NULL,
    [to_date]           DATE          NULL,
    [reporting_manager] INT           NULL,
    [department]        INT           NULL,
    [designation]       INT           NULL,
    [role]              INT           NULL,
    [active]            BIT           CONSTRAINT [DF_EmployeeTenure_active] DEFAULT ((1)) NULL,
    [created_by]        NVARCHAR (50) NOT NULL,
    [created_date]      DATETIME      NOT NULL,
    [modified_by]       NVARCHAR (50) NULL,
    [modified_date]     DATETIME      NULL,
    CONSTRAINT [PK_EmployeeTenure] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EmployeeTenure_Employee_Id] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmployeeTenure_Employee_Manager] FOREIGN KEY ([reporting_manager]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmployeeTenure_Master_Department] FOREIGN KEY ([department]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_EmployeeTenure_Master_Designation] FOREIGN KEY ([designation]) REFERENCES [dbo].[Master] ([id])
);

