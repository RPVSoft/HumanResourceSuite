CREATE TABLE [dbo].[LeavePolicy] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
    [company_id]        INT           NOT NULL,
    [earned_leave]      TINYINT       CONSTRAINT [DF_LeavePolicy_earned_leave] DEFAULT ((0)) NULL,
    [casual_leave]      TINYINT       CONSTRAINT [DF_LeavePolicy_casual_leave] DEFAULT ((0)) NULL,
    [sick_leave]        TINYINT       CONSTRAINT [DF_LeavePolicy_sick_leave] DEFAULT ((0)) NULL,
    [maternity_leave]   TINYINT       CONSTRAINT [DF_LeavePolicy_maternity_leave] DEFAULT ((0)) NULL,
    [paternity_leave]   TINYINT       CONSTRAINT [DF_LeavePolicy_paternity_leave] DEFAULT ((0)) NULL,
    [study_leave]       TINYINT       CONSTRAINT [DF_LeavePolicy_study_leave] DEFAULT ((0)) NULL,
    [bereavement_leave] TINYINT       CONSTRAINT [DF_LeavePolicy_bereavement_leave] DEFAULT ((0)) NULL,
    [created_by]        NVARCHAR (50) NOT NULL,
    [created_date]      DATETIME      NOT NULL,
    [modified_by]       NVARCHAR (50) NULL,
    [modified_date]     DATETIME      NULL,
    CONSTRAINT [PK_LeavePolicy] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_LeavePolicy_Companies] FOREIGN KEY ([company_id]) REFERENCES [dbo].[Companies] ([id])
);

