CREATE TABLE [dbo].[EmployeeQualifications] (
    [id]                  INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]         INT             NOT NULL,
    [emp_code]            NCHAR (10)      NOT NULL,
    [qualification_level] INT             NOT NULL,
    [course]              INT             NOT NULL,
    [course_ot]           NVARCHAR (50)   NULL,
    [school_university]   NVARCHAR (MAX)  NULL,
    [marks_percentage]    DECIMAL (18, 2) NULL,
    [verified]            BIT             CONSTRAINT [DF_EmployeeQualifications_verified] DEFAULT ((0)) NULL,
    [created_by]          NVARCHAR (50)   NOT NULL,
    [created_date]        DATETIME        NOT NULL,
    [modified_by]         NVARCHAR (50)   NULL,
    [modified_date]       DATETIME        NULL,
    CONSTRAINT [PK_EmployeeQualifications] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EmployeeQualifications_Employee_Id] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([id]),
    CONSTRAINT [FK_EmployeeQualifications_Master_Course] FOREIGN KEY ([course]) REFERENCES [dbo].[Master] ([id]),
    CONSTRAINT [FK_EmployeeQualifications_Master_Qual_Level] FOREIGN KEY ([qualification_level]) REFERENCES [dbo].[Master] ([id])
);

