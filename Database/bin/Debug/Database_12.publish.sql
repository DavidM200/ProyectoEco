﻿/*
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
PRINT N'Modificando Tabla [dbo].[Sim]...';


GO
ALTER TABLE [dbo].[Sim] ALTER COLUMN [PUK] VARCHAR (8) NOT NULL;


GO
PRINT N'Creando Tabla [dbo].[LinesEmployee]...';


GO
CREATE TABLE [dbo].[LinesEmployee] (
    [ID]         INT      IDENTITY (1, 1) NOT NULL,
    [IDLine]     INT      NOT NULL,
    [IDEmployee] INT      NOT NULL,
    [StartDate]  DATETIME NOT NULL,
    [FinishDate] DATETIME NULL,
    CONSTRAINT [PK_LinesEmployee] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[LinesEmployeeTerminal]...';


GO
CREATE TABLE [dbo].[LinesEmployeeTerminal] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [IDLine]     INT NOT NULL,
    [IDEmployee] INT NOT NULL,
    [IDTerminal] INT NOT NULL,
    CONSTRAINT [PK_LinesEmployeeTerminal] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[LinesTerminal]...';


GO
CREATE TABLE [dbo].[LinesTerminal] (
    [ID]         INT      IDENTITY (1, 1) NOT NULL,
    [IDLine]     INT      NOT NULL,
    [IDTerminal] INT      NOT NULL,
    [StartDate]  DATETIME NOT NULL,
    [FinishDate] DATETIME NULL,
    CONSTRAINT [PK_LinesTerminal] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Actualización completada.';


GO
