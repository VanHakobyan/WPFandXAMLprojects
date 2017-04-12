
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/12/2017 21:35:22
-- Generated from EDMX file: C:\Users\Van\Source\Repos\WPFandXAMLprojects\BindingWPFtoDataBase\BindingWPFtoDataBase\modelPlayer.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DataPlayers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataPlayers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DataPlayers'
CREATE TABLE [dbo].[DataPlayers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [About] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DataPlayers'
ALTER TABLE [dbo].[DataPlayers]
ADD CONSTRAINT [PK_DataPlayers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------