CREATE TABLE [dbo].[CandidateAddress] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [candidate_id]  INT            NOT NULL,
    [address_line]  NVARCHAR (MAX) NOT NULL,
    [state]         INT            NOT NULL,
    [country]       INT            NOT NULL,
    [type]          INT            NOT NULL,
    [created_by]    NVARCHAR (50)  NOT NULL,
    [created_date]  DATETIME       NOT NULL,
    [modified_by]   NVARCHAR (50)  NULL,
    [modified_date] DATETIME       NULL,
    CONSTRAINT [PK_CandidateAddress] PRIMARY KEY CLUSTERED ([id] ASC)
);

