CREATE TABLE [dbo].[JobApplicants] (
    [id]            INT           NOT NULL,
    [job_id]        INT           NOT NULL,
    [candidate_id]  INT           NULL,
    [employee_id]   INT           NULL,
    [created_by]    NVARCHAR (50) NULL,
    [created_date]  DATETIME      NULL,
    [modified_by]   NVARCHAR (50) NULL,
    [modified_date] DATETIME      NULL,
    CONSTRAINT [PK_JobApplicants] PRIMARY KEY CLUSTERED ([id] ASC)
);

