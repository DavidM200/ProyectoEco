CREATE TABLE [dbo].[LinesEmployeeTerminal]
(
	[ID]              INT           IDENTITY (1, 1) NOT NULL,
    [IDLine]          INT           NOT NULL,
    [IDEmployee]      INT           NOT NULL,
    [IDTerminal]      INT           NOT NULL,
    
    CONSTRAINT [PK_LinesEmployeeTerminal] PRIMARY KEY CLUSTERED ([ID] ASC)
)
