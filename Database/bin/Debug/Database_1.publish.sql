/*
Script de implementación para master

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "master"
:setvar DefaultFilePrefix "master"
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
Debe agregarse la columna [dbo].[Terminals].[BuyDate] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[FeeAmount] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[IdPayMethod] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[IdTerminalState] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[Imei] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[NumberOfFees] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[Paid] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.

Debe agregarse la columna [dbo].[Terminals].[TotalAmount] de la tabla [dbo].[Terminals], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.
*/

IF EXISTS (select top 1 1 from [dbo].[Terminals])
    RAISERROR (N'Se detectaron filas. La actualización del esquema va a terminar debido a una posible pérdida de datos.', 16, 127) WITH NOWAIT

GO
PRINT N'Modificando Tabla [dbo].[Terminals]...';


GO
ALTER TABLE [dbo].[Terminals]
    ADD [Imei]            INT             NOT NULL,
        [BuyDate]         DATETIME        NOT NULL,
        [IdPayMethod]     INT             NOT NULL,
        [Paid]            BIT             NOT NULL,
        [IdTerminalState] VARCHAR (100)   NOT NULL,
        [Observations]    VARCHAR (100)   NULL,
        [FeeAmount]       DECIMAL (18, 2) NOT NULL,
        [NumberOfFees]    INT             NOT NULL,
        [TotalAmount]     DECIMAL (18, 2) NOT NULL;


GO
PRINT N'Actualización completada.';


GO
