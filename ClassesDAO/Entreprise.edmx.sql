
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/14/2017 14:09:05
-- Generated from EDMX file: C:\Users\DL-CDI\Source\Repos\ABIEnCoucheTest2\ClassesDAO\Entreprise.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABIENCOUCHE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CollaborateurESet'
CREATE TABLE [dbo].[CollaborateurESet] (
    [matriculeE] smallint  NOT NULL,
    [civiliteE] nchar(1)  NOT NULL,
    [nomE] nvarchar(20)  NOT NULL,
    [prenomE] nvarchar(20)  NOT NULL,
    [situationE] nvarchar(20)  NOT NULL,
    [photoE] nvarchar(100)  NOT NULL,
    [actifE] bit  NOT NULL
);
GO

-- Creating table 'ContratTypeESet'
CREATE TABLE [dbo].[ContratTypeESet] (
    [idContratE] int  NOT NULL,
    [dateDebutE] datetime  NOT NULL,
    [qualificationE] nvarchar(20)  NOT NULL,
    [statutE] nvarchar(20)  NOT NULL,
    [salaireE] int  NOT NULL,
    [finReelleE] datetime  NULL,
    [CollaborateurEntity_matriculeE] smallint  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_CdiE'
CREATE TABLE [dbo].[ContratTypeESet_CdiE] (
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_ContratTemporaireE'
CREATE TABLE [dbo].[ContratTypeESet_ContratTemporaireE] (
    [dateFinE] datetime  NOT NULL,
    [motifE] nvarchar(100)  NOT NULL,
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_CddE'
CREATE TABLE [dbo].[ContratTypeESet_CddE] (
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_StageE'
CREATE TABLE [dbo].[ContratTypeESet_StageE] (
    [ecoleE] nvarchar(20)  NOT NULL,
    [missionE] nvarchar(max)  NOT NULL,
    [idContratE] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [matriculeE] in table 'CollaborateurESet'
ALTER TABLE [dbo].[CollaborateurESet]
ADD CONSTRAINT [PK_CollaborateurESet]
    PRIMARY KEY CLUSTERED ([matriculeE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet'
ALTER TABLE [dbo].[ContratTypeESet]
ADD CONSTRAINT [PK_ContratTypeESet]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_CdiE'
ALTER TABLE [dbo].[ContratTypeESet_CdiE]
ADD CONSTRAINT [PK_ContratTypeESet_CdiE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_ContratTemporaireE'
ALTER TABLE [dbo].[ContratTypeESet_ContratTemporaireE]
ADD CONSTRAINT [PK_ContratTypeESet_ContratTemporaireE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_CddE'
ALTER TABLE [dbo].[ContratTypeESet_CddE]
ADD CONSTRAINT [PK_ContratTypeESet_CddE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_StageE'
ALTER TABLE [dbo].[ContratTypeESet_StageE]
ADD CONSTRAINT [PK_ContratTypeESet_StageE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CollaborateurEntity_matriculeE] in table 'ContratTypeESet'
ALTER TABLE [dbo].[ContratTypeESet]
ADD CONSTRAINT [FK_CollaborateurEntityContratTypeE]
    FOREIGN KEY ([CollaborateurEntity_matriculeE])
    REFERENCES [dbo].[CollaborateurESet]
        ([matriculeE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurEntityContratTypeE'
CREATE INDEX [IX_FK_CollaborateurEntityContratTypeE]
ON [dbo].[ContratTypeESet]
    ([CollaborateurEntity_matriculeE]);
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_CdiE'
ALTER TABLE [dbo].[ContratTypeESet_CdiE]
ADD CONSTRAINT [FK_CdiE_inherits_ContratTypeE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_ContratTemporaireE'
ALTER TABLE [dbo].[ContratTypeESet_ContratTemporaireE]
ADD CONSTRAINT [FK_ContratTemporaireE_inherits_ContratTypeE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_CddE'
ALTER TABLE [dbo].[ContratTypeESet_CddE]
ADD CONSTRAINT [FK_CddE_inherits_ContratTemporaireE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet_ContratTemporaireE]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_StageE'
ALTER TABLE [dbo].[ContratTypeESet_StageE]
ADD CONSTRAINT [FK_StageE_inherits_ContratTemporaireE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet_ContratTemporaireE]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------