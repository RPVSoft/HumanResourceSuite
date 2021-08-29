CREATE TABLE [dbo].[JobRequirements] (
    [id]                  INT            IDENTITY (1, 1) NOT NULL,
    [job_title]           NVARCHAR (50)  NOT NULL,
    [required_experience] INT            NOT NULL,
    [job_description]     NVARCHAR (MAX) NOT NULL,
    [responsibilites]     NVARCHAR (MAX) NOT NULL,
    [qualificatons]       NVARCHAR (MAX) NOT NULL,
    [expiry_date]         DATETIME       NULL,
    [location]            INT            NOT NULL,
    [is_active]           BIT            CONSTRAINT [DF_JobRequirements_is_active] DEFAULT ((0)) NOT NULL,
    [openings]            INT            NOT NULL,
    [expected_salary]     NVARCHAR (50)  NULL,
    [employment_type]     INT            NULL,
    [created_by]          NVARCHAR (50)  NOT NULL,
    [created_date]        DATETIME       NOT NULL,
    [modified_by]         NVARCHAR (50)  NULL,
    [modified_date]       DATETIME       NULL,
    CONSTRAINT [PK_JobRequirements] PRIMARY KEY CLUSTERED ([id] ASC)
);

