CREATE TABLE [dbo].[LinesEmployee]
(
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [IDLine]          INT           NOT NULL,
    [IDEmployee]      INT           NOT NULL,
    [StartDate]       DATETIME      NOT NULL,
    [FinishDate]       DATETIME     NULL,
    CONSTRAINT [PK_LinesEmployee] PRIMARY KEY CLUSTERED ([ID] ASC)
);
