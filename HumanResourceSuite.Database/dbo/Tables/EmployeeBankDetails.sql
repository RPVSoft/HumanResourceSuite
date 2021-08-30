CREATE TABLE [dbo].[EmployeeBankDetails] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]   INT           NOT NULL,
    [emp_code]      NCHAR (10)    NOT NULL,
    [bank]          NVARCHAR (50) NOT NULL,
    [account_no]    NVARCHAR (50) NULL,
    [ifsc_code]     NCHAR (10)    NULL,
    [active]        BIT           NULL,
    [created_by]    NVARCHAR (50) NULL,
    [created_date]  DATETIME      NULL,
    [modified_by]   NVARCHAR (50) NULL,
    [modified_date] DATETIME      NULL,
    CONSTRAINT [PK_EmployeeBankDetails] PRIMARY KEY CLUSTERED ([id] ASC), 
    CONSTRAINT [FK_EmployeeBankDetails_ToTable] FOREIGN KEY ([employee_id]) REFERENCES [Employee]([id])
);