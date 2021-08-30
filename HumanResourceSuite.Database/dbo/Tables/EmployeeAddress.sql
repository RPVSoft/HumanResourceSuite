CREATE TABLE [dbo].[EmployeeAddress] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]   INT            NOT NULL,
    [emp_code]      NCHAR (10)     NOT NULL,
    [address_line]  NVARCHAR (MAX) NOT NULL,
    [state]         INT            NOT NULL,
    [country]       INT            NOT NULL,
    [city]         INT            NOT NULL,
    [type]          INT            NOT NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_EmployeeAddress] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EmployeeAddress_Employee_Id] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmployeeAddress_Master_Address_Type] FOREIGN KEY ([type]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_EmployeeAddress_Master_Country] FOREIGN KEY ([country]) REFERENCES [dbo].[Countries] ([id]),
    CONSTRAINT [FK_EmployeeAddress_Master_State] FOREIGN KEY ([state]) REFERENCES [dbo].[States] ([id]),
    CONSTRAINT [FK_EmployeeAddress_Master_City] FOREIGN KEY ([city]) REFERENCES [dbo].[Cities] ([id])
);

