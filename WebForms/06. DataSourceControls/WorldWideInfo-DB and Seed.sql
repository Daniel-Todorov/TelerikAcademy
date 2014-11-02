USE [master]
GO
/****** Object:  Database [WorldWide]    Script Date: 24.10.2014 ?. 13:08:42 ?. ******/
CREATE DATABASE [WorldWide]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorldWide', FILENAME = N'D:\MSSQL12.MSSQLSERVER\MSSQL\DATA\WorldWide.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WorldWide_log', FILENAME = N'D:\MSSQL12.MSSQLSERVER\MSSQL\DATA\WorldWide_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WorldWide] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldWide].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldWide] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldWide] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldWide] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldWide] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldWide] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldWide] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldWide] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldWide] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldWide] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldWide] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldWide] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldWide] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldWide] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldWide] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldWide] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldWide] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldWide] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldWide] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldWide] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldWide] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldWide] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldWide] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldWide] SET RECOVERY FULL 
GO
ALTER DATABASE [WorldWide] SET  MULTI_USER 
GO
ALTER DATABASE [WorldWide] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldWide] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorldWide] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorldWide] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WorldWide] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WorldWide', N'ON'
GO
USE [WorldWide]
GO
/****** Object:  Table [dbo].[Continents]    Script Date: 24.10.2014 ?. 13:08:42 ?. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 24.10.2014 ?. 13:08:42 ?. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[language] [nvarchar](50) NOT NULL,
	[population] [int] NOT NULL,
	[continentId] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 24.10.2014 ?. 13:08:42 ?. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[population] [int] NOT NULL,
	[countryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Continents] ON 

GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (1, N'Europe')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (2, N'Africa')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (3, N'Asia')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (4, N'Australia')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (5, N'North America')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (6, N'South America')
GO
INSERT [dbo].[Continents] ([id], [name]) VALUES (7, N'Antarctida')
GO
SET IDENTITY_INSERT [dbo].[Continents] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (1, N'Bulgaria', N'Bulgarian', 7200000, 1)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (2, N'Germany', N'German', 81000001, 1)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (3, N'Norway', N'Norwegian', 5077000, 1)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (4, N'Sweden', N'Swedish', 9595000, 1)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (5, N'Algeria', N'Arabic', 33333267, 2)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (6, N'Burundi', N'French', 7548000, 2)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (7, N'Chad', N'French', 10146000, 2)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (8, N'Ethiopia', N'Amharic', 85237000, 2)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (9, N'China', N'Chinese', 1357379000, 3)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (10, N'India', N'Hindi', 1257476010, 3)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (11, N'Japan', N'Japanish', 127350000, 3)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (12, N'Turkey', N'Turkish', 76668000, 3)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (13, N'Australia', N'English', 23639000, 4)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (14, N'USA', N'English', 316102000, 5)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (15, N'Mexico', N'Spanish', 118419000, 5)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (16, N'Canada', N'English/French', 35236000, 5)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (17, N'Brazil', N'Portugese', 201033000, 6)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (18, N'Colombia', N'Spanish', 47130000, 6)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (19, N'Argentina', N'Spanish', 41350000, 6)
GO
INSERT [dbo].[Countries] ([id], [name], [language], [population], [continentId]) VALUES (20, N'Peru', N'Spanish', 30476000, 6)
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Towns] ON 

GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (1, N'Sofia', 1281149, 1)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (2, N'Plovdiv', 368853, 1)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (3, N'Dimitrovgrad', 39956, 1)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (4, N'Munich', 1210223, 2)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (5, N'Nuremberg', 488400, 2)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (6, N'Ausburg', 254982, 2)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (7, N'Oslo', 634463, 3)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (8, N'Trondheim', 182035, 3)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (9, N'Bergen', 271949, 3)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (10, N'Stockholm', 851155, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (11, N'Uppsala', 140154, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (12, N'Visby', 22236, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (13, N'Boden', 18680, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (14, N'Falun', 36447, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (15, N'Flen', 6114, 4)
GO
INSERT [dbo].[Towns] ([id], [name], [population], [countryId]) VALUES (17, N'Sydney', 2430000, 13)
GO
SET IDENTITY_INSERT [dbo].[Towns] OFF
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([continentId])
REFERENCES [dbo].[Continents] ([id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([countryId])
REFERENCES [dbo].[Countries] ([id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [WorldWide] SET  READ_WRITE 
GO
