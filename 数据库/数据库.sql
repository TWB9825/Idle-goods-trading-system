USE [master]
GO
/****** Object:  Database [keshe]    Script Date: 2015/8/9 19:34:52 ******/
CREATE DATABASE [keshe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'keshe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\keshe.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'keshe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\keshe_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [keshe] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [keshe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [keshe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [keshe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [keshe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [keshe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [keshe] SET ARITHABORT OFF 
GO
ALTER DATABASE [keshe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [keshe] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [keshe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [keshe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [keshe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [keshe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [keshe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [keshe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [keshe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [keshe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [keshe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [keshe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [keshe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [keshe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [keshe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [keshe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [keshe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [keshe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [keshe] SET RECOVERY FULL 
GO
ALTER DATABASE [keshe] SET  MULTI_USER 
GO
ALTER DATABASE [keshe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [keshe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [keshe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [keshe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'keshe', N'ON'
GO
USE [keshe]
GO
/****** Object:  Table [dbo].[BoughtTable]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoughtTable](
	[Uname] [nvarchar](50) NOT NULL,
	[Tname] [nvarchar](50) NOT NULL,
	[Tintro] [nvarchar](max) NOT NULL,
	[Tpic] [nvarchar](max) NOT NULL,
	[Time] [nvarchar](50) NOT NULL,
	[Tprice] [float] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BuyTable]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyTable](
	[Uname] [nvarchar](50) NOT NULL,
	[BuyName] [nvarchar](50) NOT NULL,
	[BuyDate] [nvarchar](50) NOT NULL,
	[BuyLink] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pitureTable]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pitureTable](
	[picture] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stayUser]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stayUser](
	[stayName] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[thing]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thing](
	[Uname] [nvarchar](50) NOT NULL,
	[Tname] [nvarchar](50) NOT NULL,
	[Tintro] [nvarchar](max) NOT NULL,
	[Tpic] [nvarchar](max) NOT NULL,
	[Time] [nvarchar](50) NOT NULL,
	[Tprice] [float] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usr]    Script Date: 2015/8/9 19:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr](
	[Uname] [nvarchar](50) NOT NULL,
	[Uschool] [nvarchar](50) NOT NULL,
	[Uphone] [nvarchar](50) NOT NULL,
	[Uemail] [nvarchar](50) NULL,
	[Upwd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_usr] PRIMARY KEY CLUSTERED 
(
	[Uname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[BuyTable]  WITH CHECK ADD  CONSTRAINT [FK_BuyTable_usr] FOREIGN KEY([BuyName])
REFERENCES [dbo].[usr] ([Uname])
GO
ALTER TABLE [dbo].[BuyTable] CHECK CONSTRAINT [FK_BuyTable_usr]
GO
ALTER TABLE [dbo].[BuyTable]  WITH CHECK ADD  CONSTRAINT [FK_BuyTable_usr1] FOREIGN KEY([Uname])
REFERENCES [dbo].[usr] ([Uname])
GO
ALTER TABLE [dbo].[BuyTable] CHECK CONSTRAINT [FK_BuyTable_usr1]
GO
ALTER TABLE [dbo].[thing]  WITH CHECK ADD  CONSTRAINT [FK_thing_usr] FOREIGN KEY([Uname])
REFERENCES [dbo].[usr] ([Uname])
GO
ALTER TABLE [dbo].[thing] CHECK CONSTRAINT [FK_thing_usr]
GO
USE [master]
GO
ALTER DATABASE [keshe] SET  READ_WRITE 
GO
