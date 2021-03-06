/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4206)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2008
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [master]
GO
/****** Object:  Database [DbTest]    Script Date: 1/24/2018 10:40:35 PM ******/
CREATE DATABASE [DbTest] ON  PRIMARY 
( NAME = N'DbTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DbTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DbTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbTest] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DbTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbTest] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DbTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbTest] SET  MULTI_USER 
GO
ALTER DATABASE [DbTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbTest] SET DB_CHAINING OFF 
GO
USE [DbTest]
GO
/****** Object:  Table [dbo].[Incident]    Script Date: 1/24/2018 10:40:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incident](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kind] [varchar](30) NULL,
	[LocationId] [varchar](30) NULL,
	[HappenedAt] [date] NULL,
	[IsArchive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locality]    Script Date: 1/24/2018 10:40:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locality](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Incident] ON 
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (1, N'TEST', N'TEST', CAST(N'2017-01-01' AS Date), 1)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (2, N'TEST1', N'TEST1', CAST(N'2017-01-01' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (3, N'TEST2', N'TEST2', CAST(N'2017-01-01' AS Date), 1)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (4, N'TEST3', N'TEST3', CAST(N'2017-01-01' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (5, N'TEST4', N'TEST4', CAST(N'2017-01-01' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (6, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (7, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (8, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (9, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (10, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (11, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (12, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (13, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (14, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (15, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (16, N'preueba', N'cnsdkn', CAST(N'2018-01-24' AS Date), NULL)
GO
INSERT [dbo].[Incident] ([Id], [Kind], [LocationId], [HappenedAt], [IsArchive]) VALUES (17, N'TEST', N'TEST', CAST(N'2018-01-24' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[Incident] OFF
GO
SET IDENTITY_INSERT [dbo].[Locality] ON 
GO
INSERT [dbo].[Locality] ([Id], [Name]) VALUES (1, N'Los Alcarrizos')
GO
SET IDENTITY_INSERT [dbo].[Locality] OFF
GO
USE [master]
GO
ALTER DATABASE [DbTest] SET  READ_WRITE 
GO
