CREATE TABLE [dbo].[EmployeeSalaryDetails] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]    INT           NOT NULL,
    [emp_code]       NCHAR (10)    NOT NULL,
    [tenure]         INT           NOT NULL,
    [from_date]      DATE          NULL,
    [to_date]        DATE          NULL,
    [financial_year] NCHAR (10)    NULL,
    [basic_pay]      NVARCHAR (10) NULL,
    [created_by]     NVARCHAR (50) NULL,
    [created_date]   DATETIME      NULL,
    [modified_by]    NVARCHAR (50) NULL,
    [modified_date]  DATETIME      NULL,
    CONSTRAINT [PK_EmployeeSalaryDetails] PRIMARY KEY CLUSTERED ([id] ASC)
);

