CREATE TABLE [dbo].[TerminalState]
(
	[ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_TerminalState] PRIMARY KEY CLUSTERED ([ID] ASC)
)
