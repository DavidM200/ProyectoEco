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
/*
Se está quitando la columna [dbo].[Lines].[PIN]; puede que se pierdan datos.

Se está quitando la columna [dbo].[Lines].[PUK]; puede que se pierdan datos.

Se está quitando la columna [dbo].[Lines].[SerialSimNumber]; puede que se pierdan datos.

Se está quitando la columna [dbo].[Lines].[SimType]; puede que se pierdan datos.
*/

IF EXISTS (select top 1 1 from [dbo].[Lines])
    RAISERROR (N'Se detectaron filas. La actualización del esquema va a terminar debido a una posible pérdida de datos.', 16, 127) WITH NOWAIT

GO
/*
El tipo de la columna Type en la tabla [dbo].[Sim] es  NVARCHAR (50) NOT NULL, pero se va a cambiar a  VARCHAR (50) NOT NULL. Si la columna contiene datos no compatibles con el tipo  VARCHAR (50) NOT NULL, podrían producirse pérdidas de datos y errores en la implementación.
*/

IF EXISTS (select top 1 1 from [dbo].[Sim])
    RAISERROR (N'Se detectaron filas. La actualización del esquema va a terminar debido a una posible pérdida de datos.', 16, 127) WITH NOWAIT

GO
PRINT N'Quitando Clave externa [dbo].[FK_Lines_Companies]...';


GO
ALTER TABLE [dbo].[Lines] DROP CONSTRAINT [FK_Lines_Companies];


GO
PRINT N'Modificando Tabla [dbo].[Lines]...';


GO
ALTER TABLE [dbo].[Lines] DROP COLUMN [PIN], COLUMN [PUK], COLUMN [SerialSimNumber], COLUMN [SimType];


GO
PRINT N'Modificando Tabla [dbo].[Sim]...';


GO
ALTER TABLE [dbo].[Sim] ALTER COLUMN [Type] VARCHAR (50) NOT NULL;


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
PRINT N'Actualización completada.';


GO
