USE [master]
GO
/****** Object:  Database [JeuDontOnEstLeHeros.database.dev]    Script Date: 29/02/2024 1:24:37 AM ******/
CREATE DATABASE [JeuDontOnEstLeHeros.database.dev]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JeuDontOnEstLeHeros.database.dev', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2012\MSSQL\DATA\JeuDontOnEstLeHeros.database.dev.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JeuDontOnEstLeHeros.database.dev_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2012\MSSQL\DATA\JeuDontOnEstLeHeros.database.dev_log.ldf' , SIZE = 7168KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JeuDontOnEstLeHeros.database.dev].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ARITHABORT OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET RECOVERY FULL 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET  MULTI_USER 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JeuDontOnEstLeHeros.database.dev', N'ON'
GO
USE [JeuDontOnEstLeHeros.database.dev]
GO
/****** Object:  Table [dbo].[Aventure]    Script Date: 29/02/2024 1:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aventure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titre] [nvarchar](250) NOT NULL,
	[dateCreation] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Droide]    Script Date: 29/02/2024 1:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Droide](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricule] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Droide] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Aventure] ADD  CONSTRAINT [DF_Aventure_dateCreation]  DEFAULT (getdate()) FOR [dateCreation]
GO
USE [master]
GO
ALTER DATABASE [JeuDontOnEstLeHeros.database.dev] SET  READ_WRITE 
GO
