CREATE TABLE [dbo].[Sim] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [IDLine]          INT           NOT NULL,
    [NSerie]          VARCHAR (100) NOT NULL,
    [Type]            VARCHAR (50)  NOT NULL,
    [Number]          INT           NOT NULL,
    [PIN]             VARCHAR (4)          NOT NULL,
    [PUK]             VARCHAR(8)           NOT NULL,
    CONSTRAINT [PK_Sim] PRIMARY KEY CLUSTERED ([ID] ASC)
);

