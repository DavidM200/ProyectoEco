﻿CREATE TABLE [dbo].[PayMethod]
(
	[ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_PayMethod] PRIMARY KEY CLUSTERED ([ID] ASC)
)
