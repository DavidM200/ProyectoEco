CREATE TABLE [dbo].[Companies] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    [AdmitDate]       DATETIME      NOT NULL,
    [DischargeDate]   DATETIME      NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([ID] ASC)
);

