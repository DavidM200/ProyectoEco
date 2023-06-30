CREATE TABLE [dbo].[Rates] (
    [ID]               INT             IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (500)   NOT NULL,
    [IDCompany]        INT             NOT NULL,
    [Amount]           DECIMAL (18, 2) NOT NULL,
    [Discount]         DECIMAL (18, 2) NOT NULL,
    [MonthlyNetAmount] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED ([ID] ASC)
);

