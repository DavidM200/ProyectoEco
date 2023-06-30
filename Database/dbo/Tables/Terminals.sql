CREATE TABLE [dbo].[Terminals] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    [Imei] VARCHAR(50) NOT NULL,
    [BuyDate] DATETIME NOT NULL,
    [IdPayMethod] INT NOT NULL,
    [Paid] BIT NOT NULL,
    [IdTerminalState] INT NOT NULL,
    [Observations] VARCHAR (100)  NULL,
    [FeeAmount] DECIMAL (18, 2) NOT NULL,
    [NumberOfFees] INT NOT NULL,
    [TotalAmount] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Terminals] PRIMARY KEY CLUSTERED ([ID] ASC)
);

