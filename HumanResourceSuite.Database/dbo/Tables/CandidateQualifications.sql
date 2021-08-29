CREATE TABLE [dbo].[CandidateQualifications] (
    [id]                  INT             IDENTITY (1, 1) NOT NULL,
    [candidate_id]        INT             NOT NULL,
    [qualification_level] INT             NOT NULL,
    [course]              INT             NOT NULL,
    [course_ot]           NVARCHAR (50)   NULL,
    [school_university]   NVARCHAR (MAX)  NULL,
    [marks_percentage]    DECIMAL (18, 2) NULL,
    [verified]            BIT             NULL,
    [created_by]          NVARCHAR (50)   NOT NULL,
    [created_date]        DATETIME        NOT NULL,
    [modified_by]         NVARCHAR (50)   NULL,
    [modified_date]       DATETIME        NULL,
    CONSTRAINT [PK_CandidateQualifications] PRIMARY KEY CLUSTERED ([id] ASC)
);

