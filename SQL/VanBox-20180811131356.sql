/*
 Navicat Premium Data Transfer

 Source Server         : docker mssql
 Source Server Type    : SQL Server
 Source Server Version : 14003030
 Source Host           : 127.0.0.1:1433
 Source Catalog        : vanbox
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14003030
 File Encoding         : 65001

 Date: 11/08/2018 19:15:57
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801132618_Init', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801133423_ChangeTypes', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801142233_TblNameChange', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801143508_SeedDb', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801152151_SeedDbNew', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801183344_VehicleModel', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801185016_VehiclesTblNameUpdate', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180801185140_SeedVehicles', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180804184323_TblVehicleFeature', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180804202125_TblFeatureAndVehicleUpdate', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180804202355_SeedVehicleFeature', N'2.1.1-rtm-30846')
GO

INSERT INTO [dbo].[__EFMigrationsHistory]  VALUES (N'20180811131356_FieldAdded', N'2.1.1-rtm-30846')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Features
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Features]') AND type IN ('U'))
	DROP TABLE [dbo].[Features]
GO

CREATE TABLE [dbo].[Features] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Features] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for FeatureVehicles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[FeatureVehicles]') AND type IN ('U'))
	DROP TABLE [dbo].[FeatureVehicles]
GO

CREATE TABLE [dbo].[FeatureVehicles] (
  [VehicleId] int  NOT NULL,
  [FeatureId] int  NOT NULL
)
GO

ALTER TABLE [dbo].[FeatureVehicles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Makes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Makes]') AND type IN ('U'))
	DROP TABLE [dbo].[Makes]
GO

CREATE TABLE [dbo].[Makes] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Makes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Makes
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Makes] ON
GO

INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (N'1', N'BMW')
GO

INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (N'2', N'TOYOTA')
GO

INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (N'3', N'Ford')
GO

SET IDENTITY_INSERT [dbo].[Makes] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Models
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Models]') AND type IN ('U'))
	DROP TABLE [dbo].[Models]
GO

CREATE TABLE [dbo].[Models] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [MakeId] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Models] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Models
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Models] ON
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'1', N'BMW-1', N'1')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'2', N'BMW-2', N'1')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'3', N'BMW-3', N'1')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'4', N'Toyota-1', N'2')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'5', N'Toyota-2', N'2')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'6', N'Toyota-3', N'2')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'7', N'Ford-1', N'3')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'8', N'Ford-2', N'3')
GO

INSERT INTO [dbo].[Models] ([Id], [Name], [MakeId]) VALUES (N'9', N'Ford-3', N'3')
GO

SET IDENTITY_INSERT [dbo].[Models] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Vehicles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Vehicles]') AND type IN ('U'))
	DROP TABLE [dbo].[Vehicles]
GO

CREATE TABLE [dbo].[Vehicles] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [ContactName] nvarchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ModelId] int  NOT NULL,
  [ContactEmail] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ContactPhone] int DEFAULT ((0)) NOT NULL,
  [IsRegister] bit DEFAULT ((0)) NOT NULL
)
GO

ALTER TABLE [dbo].[Vehicles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Vehicles
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Vehicles] ON
GO

INSERT INTO [dbo].[Vehicles] ([Id], [ContactName], [ModelId], [ContactEmail], [ContactPhone], [IsRegister]) VALUES (N'5', N'Toyota Vec 1', N'5', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Vehicles] ([Id], [ContactName], [ModelId], [ContactEmail], [ContactPhone], [IsRegister]) VALUES (N'6', N'Toyota Vec 2', N'5', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Vehicles] ([Id], [ContactName], [ModelId], [ContactEmail], [ContactPhone], [IsRegister]) VALUES (N'7', N'BMW X 1', N'2', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Vehicles] ([Id], [ContactName], [ModelId], [ContactEmail], [ContactPhone], [IsRegister]) VALUES (N'8', N'BMW X 2', N'1', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Vehicles] ([Id], [ContactName], [ModelId], [ContactEmail], [ContactPhone], [IsRegister]) VALUES (N'9', N'Mustang', N'8', NULL, N'0', N'0')
GO

SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO

COMMIT
GO


-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Features
-- ----------------------------
ALTER TABLE [dbo].[Features] ADD CONSTRAINT [PK_Features] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table FeatureVehicles
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_FeatureVehicles_FeatureId]
ON [dbo].[FeatureVehicles] (
  [FeatureId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table FeatureVehicles
-- ----------------------------
ALTER TABLE [dbo].[FeatureVehicles] ADD CONSTRAINT [PK_FeatureVehicles] PRIMARY KEY CLUSTERED ([VehicleId], [FeatureId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Makes
-- ----------------------------
ALTER TABLE [dbo].[Makes] ADD CONSTRAINT [PK_Makes] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Models
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Models_MakeId]
ON [dbo].[Models] (
  [MakeId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Models
-- ----------------------------
ALTER TABLE [dbo].[Models] ADD CONSTRAINT [PK_Models] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Vehicles
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Vehicles_ModelId]
ON [dbo].[Vehicles] (
  [ModelId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Vehicles
-- ----------------------------
ALTER TABLE [dbo].[Vehicles] ADD CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table FeatureVehicles
-- ----------------------------
ALTER TABLE [dbo].[FeatureVehicles] ADD CONSTRAINT [FK_FeatureVehicles_Features_FeatureId] FOREIGN KEY ([FeatureId]) REFERENCES [dbo].[Features] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[FeatureVehicles] ADD CONSTRAINT [FK_FeatureVehicles_Vehicles_VehicleId] FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[Vehicles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Models
-- ----------------------------
ALTER TABLE [dbo].[Models] ADD CONSTRAINT [FK_Models_Makes_MakeId] FOREIGN KEY ([MakeId]) REFERENCES [dbo].[Makes] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Vehicles
-- ----------------------------
ALTER TABLE [dbo].[Vehicles] ADD CONSTRAINT [FK_Vehicles_Models_ModelId] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[Models] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

