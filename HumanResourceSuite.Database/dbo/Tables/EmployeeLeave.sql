CREATE TABLE [dbo].[EmployeeLeave] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [leave_type]    INT            NOT NULL,
    [employee_id]   INT            NOT NULL,
    [emp_code]      NCHAR (10)     NOT NULL,
    [from_date]     DATETIME       NOT NULL,
    [to_date]       DATETIME       NOT NULL,
    [reason]        NVARCHAR (MAX) NOT NULL,
    [status]        INT            NOT NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_EmployeeLeave] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EmployeeLeave_Employee] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmployeeLeave_Master] FOREIGN KEY ([leave_type]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_EmployeeLeave_Master1] FOREIGN KEY ([status]) REFERENCES [dbo].[Master] ([id])
);

