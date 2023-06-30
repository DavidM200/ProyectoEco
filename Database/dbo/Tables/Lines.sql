CREATE TABLE [dbo].[Lines] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [IDCompany]       INT           NOT NULL,
    [AdmitDate]       DATETIME      NOT NULL,
    [DischargeDate]   DATETIME      NULL,
    [IDRate]          INT           NOT NULL,
    [Observations]    VARCHAR (100) NULL,
    [PhoneNumber]     INT           NOT NULL
   
    CONSTRAINT [PK_Lines] PRIMARY KEY CLUSTERED ([ID] ASC)
);

