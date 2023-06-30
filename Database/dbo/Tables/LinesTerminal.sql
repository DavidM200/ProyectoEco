CREATE TABLE [dbo].[LinesTerminal]
(
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [IDLine]          INT           NOT NULL,
    [IDTerminal]      INT           NOT NULL,
    [StartDate]       DATETIME      NOT NULL,
    [FinishDate]       DATETIME     NULL,
    CONSTRAINT [PK_LinesTerminal] PRIMARY KEY CLUSTERED ([ID] ASC)
);
