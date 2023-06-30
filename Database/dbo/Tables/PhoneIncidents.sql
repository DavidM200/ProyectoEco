CREATE TABLE [dbo].[PhoneIncidents]
(
	[ID]			INT		IDENTITY(1,1) NOT NULL,
	[IdTerminal]	INT		NOT NULL,
	[IdEmployee]	INT		NOT NULL,
	[Description]   VARCHAR (100) NULL,
	[Amount]		DECIMAL (18,2) NULL
	CONSTRAINT [PK_PhoneIncidents] PRIMARY KEY CLUSTERED ([ID] ASC)
)
