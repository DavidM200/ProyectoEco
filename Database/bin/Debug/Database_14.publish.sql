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
Debe agregarse la columna [dbo].[Companies].[AdmitDate] de la tabla [dbo].[Companies], pero esta columna no tiene un valor predeterminado y no admite valores NULL. Si la tabla contiene datos, el script ALTER no funcionará. Para evitar esta incidencia, agregue un valor predeterminado a la columna, márquela de modo que permita valores NULL o habilite la generación de valores predeterminados inteligentes como opción de implementación.
*/

IF EXISTS (select top 1 1 from [dbo].[Companies])
    RAISERROR (N'Se detectaron filas. La actualización del esquema va a terminar debido a una posible pérdida de datos.', 16, 127) WITH NOWAIT

GO
PRINT N'Modificando Tabla [dbo].[Companies]...';


GO
ALTER TABLE [dbo].[Companies]
    ADD [AdmitDate]     DATETIME NOT NULL,
        [DischargeDate] DATETIME NULL;


GO
PRINT N'Creando Tabla [dbo].[Rates]...';


GO
CREATE TABLE [dbo].[Rates] (
    [ID]               INT             IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (500)   NOT NULL,
    [IDCompany]        INT             NOT NULL,
    [Amount]           DECIMAL (18, 2) NOT NULL,
    [Discount]         DECIMAL (18, 2) NOT NULL,
    [MonthlyNetAmount] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Actualización completada.';


GO
