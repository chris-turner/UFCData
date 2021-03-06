USE [master]
GO
/****** Object:  Database [UFCData]    Script Date: 10/18/2020 6:09:41 AM ******/
CREATE DATABASE [UFCData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UFCData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UFCData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UFCData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UFCData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UFCData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UFCData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UFCData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UFCData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UFCData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UFCData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UFCData] SET ARITHABORT OFF 
GO
ALTER DATABASE [UFCData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UFCData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UFCData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UFCData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UFCData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UFCData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UFCData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UFCData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UFCData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UFCData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UFCData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UFCData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UFCData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UFCData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UFCData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UFCData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UFCData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UFCData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UFCData] SET  MULTI_USER 
GO
ALTER DATABASE [UFCData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UFCData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UFCData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UFCData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UFCData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UFCData] SET QUERY_STORE = OFF
GO
USE [UFCData]
GO
/****** Object:  Table [dbo].[Fight]    Script Date: 10/18/2020 6:09:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fight](
	[fighter1] [varchar](255) NULL,
	[fighter2] [varchar](255) NULL,
	[weightclass] [varchar](255) NULL,
	[method] [varchar](255) NULL,
	[timefinished] [varchar](255) NULL,
	[format] [varchar](255) NULL,
	[referee] [varchar](255) NULL,
	[bonus] [varchar](255) NULL,
	[details] [varchar](255) NULL,
	[fighter1outcome] [varchar](255) NULL,
	[fighter2outcome] [varchar](255) NULL,
	[fightcardID] [int] NULL,
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FightCard]    Script Date: 10/18/2020 6:09:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FightCard](
	[name] [varchar](255) NULL,
	[date] [varchar](255) NULL,
	[location] [varchar](255) NULL,
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fighter]    Script Date: 10/18/2020 6:09:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fighter](
	[name] [varchar](255) NULL,
	[height] [varchar](255) NULL,
	[weight] [varchar](255) NULL,
	[reach] [varchar](255) NULL,
	[stance] [varchar](255) NULL,
	[dob] [date] NULL,
	[nickname] [varchar](255) NULL,
	[wins] [int] NULL,
	[losses] [int] NULL,
	[draws] [int] NULL,
	[id] [int] NULL,
	[NCs] [int] NULL,
	[fighterID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FightStats]    Script Date: 10/18/2020 6:09:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FightStats](
	[id] [int] NULL,
	[fightername] [varchar](255) NULL,
	[fighterid] [int] NULL,
	[knockdown] [int] NULL,
	[landersigstrikes] [int] NULL,
	[totalsigstrikes] [int] NULL,
	[takedowns] [int] NULL,
	[takedownattempts] [nvarchar](255) NULL,
	[submissionattempt] [nvarchar](255) NULL,
	[pass] [int] NULL,
	[control] [nvarchar](255) NULL,
	[fightid] [int] NULL,
	[landedStrikes] [int] NULL,
	[totalStrikes] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignificantStrikes]    Script Date: 10/18/2020 6:09:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignificantStrikes](
	[fighername] [varchar](255) NULL,
	[fighterid] [int] NULL,
	[fightid] [int] NULL,
	[round] [int] NULL,
	[headstrikeslanded] [int] NULL,
	[headstrikesattempted] [int] NULL,
	[bodystrikeslanded] [int] NULL,
	[legstrikeslanded] [int] NULL,
	[legstrikesattempted] [int] NULL,
	[distancestrikeslanded] [int] NULL,
	[distancestrikesattempted] [int] NULL,
	[clinchstrikeslanded] [int] NULL,
	[clinchstrikesattempted] [int] NULL,
	[groundstrikeslanded] [int] NULL,
	[groundstrikesattempted] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [UFCData] SET  READ_WRITE 
GO
