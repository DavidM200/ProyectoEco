/*
Script de implementación para GestionTelefonos

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "GestionTelefonos"
:setvar DefaultFilePrefix "GestionTelefonos"
:setvar DefaultDataPath "F:\MSSSQL2019\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\"
:setvar DefaultLogPath "F:\MSSSQL2019\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creando Tabla [dbo].[Companies]...';


GO
CREATE TABLE [dbo].[Companies] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Employees]...';


GO
CREATE TABLE [dbo].[Employees] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Lines]...';


GO
CREATE TABLE [dbo].[Lines] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [IDCompany]     INT           NOT NULL,
    [AdmitDate]     DATETIME      NOT NULL,
    [DischargeDate] DATETIME      NULL,
    [IDRate]        INT           NOT NULL,
    [Observations]  VARCHAR (100) NULL,
    [PhoneNumber]   INT           NOT NULL,
    CONSTRAINT [PK_Lines] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[PhoneIncidents]...';


GO
CREATE TABLE [dbo].[PhoneIncidents] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [IdTerminal]  INT             NOT NULL,
    [IdEmployee]  INT             NOT NULL,
    [Description] VARCHAR (100)   NULL,
    [Amount]      DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_PhoneIncidents] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Rates]...';


GO
CREATE TABLE [dbo].[Rates] (
    [ID]               INT             IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (500)   NOT NULL,
    [Amount]           DECIMAL (18, 2) NOT NULL,
    [Discount]         DECIMAL (18, 2) NOT NULL,
    [MonthlyNetAmount] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Sim]...';


GO
CREATE TABLE [dbo].[Sim] (
    [ID]     INT           IDENTITY (1, 1) NOT NULL,
    [IDLine] INT           NOT NULL,
    [NSerie] VARCHAR (100) NOT NULL,
    [Type]   VARCHAR (50)  NOT NULL,
    [Number] INT           NOT NULL,
    [PIN]    INT           NOT NULL,
    [PUK]    INT           NOT NULL,
    CONSTRAINT [PK_Sim] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Terminals]...';


GO
CREATE TABLE [dbo].[Terminals] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (500)   NOT NULL,
    [Imei]            INT             NOT NULL,
    [BuyDate]         DATETIME        NOT NULL,
    [IdPayMethod]     INT             NOT NULL,
    [Paid]            BIT             NOT NULL,
    [IdTerminalState] VARCHAR (100)   NOT NULL,
    [Observations]    VARCHAR (100)   NULL,
    [FeeAmount]       DECIMAL (18, 2) NOT NULL,
    [NumberOfFees]    INT             NOT NULL,
    [TotalAmount]     DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Terminals] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Actualización completada.';


GO
