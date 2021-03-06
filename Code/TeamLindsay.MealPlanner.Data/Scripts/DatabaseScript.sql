USE [MealPlanner]
GO
ALTER TABLE [dbo].[Meals] DROP CONSTRAINT [FK_Meals_MealTypes]
GO
ALTER TABLE [dbo].[MealRecipes] DROP CONSTRAINT [FK_MealRecipes_Recipes]
GO
ALTER TABLE [dbo].[MealRecipes] DROP CONSTRAINT [FK_MealRecipes_Meals]
GO
/****** Object:  View [dbo].[MealRecipeListView]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP VIEW [dbo].[MealRecipeListView]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP TABLE [dbo].[Recipes]
GO
/****** Object:  Table [dbo].[MealTypes]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP TABLE [dbo].[MealTypes]
GO
/****** Object:  Table [dbo].[MealRecipes]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP TABLE [dbo].[MealRecipes]
GO
/****** Object:  Table [dbo].[Meals]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP TABLE [dbo].[Meals]
GO
/****** Object:  User [DbUser]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP USER [DbUser]
GO
USE [master]
GO
/****** Object:  Database [MealPlanner]    Script Date: 8/25/2018 8:33:15 PM ******/
DROP DATABASE [MealPlanner]
GO
/****** Object:  Database [MealPlanner]    Script Date: 8/25/2018 8:33:15 PM ******/
CREATE DATABASE [MealPlanner]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MealPlanner', FILENAME = N'D:\Dropbox\Sites\TeamLindsay\Databases\MealPlanner\MealPlanner.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MealPlanner_log', FILENAME = N'D:\Dropbox\Sites\TeamLindsay\Databases\MealPlanner\MealPlanner_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MealPlanner] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MealPlanner].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MealPlanner] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MealPlanner] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MealPlanner] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MealPlanner] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MealPlanner] SET ARITHABORT OFF 
GO
ALTER DATABASE [MealPlanner] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MealPlanner] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MealPlanner] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MealPlanner] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MealPlanner] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MealPlanner] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MealPlanner] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MealPlanner] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MealPlanner] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MealPlanner] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MealPlanner] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MealPlanner] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MealPlanner] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MealPlanner] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MealPlanner] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MealPlanner] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MealPlanner] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MealPlanner] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MealPlanner] SET  MULTI_USER 
GO
ALTER DATABASE [MealPlanner] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MealPlanner] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MealPlanner] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MealPlanner] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MealPlanner] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MealPlanner] SET QUERY_STORE = OFF
GO
USE [MealPlanner]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MealPlanner]
GO
/****** Object:  User [DbUser]    Script Date: 8/25/2018 8:33:15 PM ******/
CREATE USER [DbUser] FOR LOGIN [DbUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [DbUser]
GO
/****** Object:  Table [dbo].[Meals]    Script Date: 8/25/2018 8:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MealDate] [datetime] NOT NULL,
	[MealTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Meals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MealRecipes]    Script Date: 8/25/2018 8:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MealRecipes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MealId] [int] NOT NULL,
	[RecipeId] [int] NOT NULL,
 CONSTRAINT [PK_MealRecipes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MealTypes]    Script Date: 8/25/2018 8:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MealTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MealTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 8/25/2018 8:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Ingredients] [nvarchar](1000) NULL,
	[Instructions] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MealRecipeListView]    Script Date: 8/25/2018 8:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   view [dbo].[MealRecipeListView]
as
	select 
		m.Id MealId,
		m.MealDate,
		mt.Id MealTypeId,
		mt.Name MealType,
		r.Id RecipeId,
		r.Name RecipeName,
		r.Ingredients Ingredients,
		r.Instructions Instructions
	from Meals m
		join MealTypes mt on m.MealTypeId = mt.Id
		join MealRecipes x on m.Id = x.MealId
		join Recipes r on x.RecipeId = r.Id
GO
SET IDENTITY_INSERT [dbo].[MealRecipes] ON 

INSERT [dbo].[MealRecipes] ([Id], [MealId], [RecipeId]) VALUES (64, 69, 74)
INSERT [dbo].[MealRecipes] ([Id], [MealId], [RecipeId]) VALUES (65, 70, 76)
INSERT [dbo].[MealRecipes] ([Id], [MealId], [RecipeId]) VALUES (66, 71, 77)
INSERT [dbo].[MealRecipes] ([Id], [MealId], [RecipeId]) VALUES (67, 72, 75)
SET IDENTITY_INSERT [dbo].[MealRecipes] OFF
SET IDENTITY_INSERT [dbo].[Meals] ON 

INSERT [dbo].[Meals] ([Id], [MealDate], [MealTypeId]) VALUES (69, CAST(N'2018-10-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Meals] ([Id], [MealDate], [MealTypeId]) VALUES (70, CAST(N'2018-10-01T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Meals] ([Id], [MealDate], [MealTypeId]) VALUES (71, CAST(N'2018-10-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Meals] ([Id], [MealDate], [MealTypeId]) VALUES (72, CAST(N'2018-10-02T00:00:00.000' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[Meals] OFF
SET IDENTITY_INSERT [dbo].[MealTypes] ON 

INSERT [dbo].[MealTypes] ([Id], [Name]) VALUES (1, N'Breakfast')
INSERT [dbo].[MealTypes] ([Id], [Name]) VALUES (2, N'Lunch')
INSERT [dbo].[MealTypes] ([Id], [Name]) VALUES (3, N'Dinner')
SET IDENTITY_INSERT [dbo].[MealTypes] OFF
SET IDENTITY_INSERT [dbo].[Recipes] ON 

INSERT [dbo].[Recipes] ([Id], [Name], [Ingredients], [Instructions]) VALUES (74, N'Crepes', N'batter', N'crepe pan and love')
INSERT [dbo].[Recipes] ([Id], [Name], [Ingredients], [Instructions]) VALUES (75, N'Fried Chicken', N'Chicken and other stuff', N'Make it like this')
INSERT [dbo].[Recipes] ([Id], [Name], [Ingredients], [Instructions]) VALUES (76, N'Tacos', N'Ground Turkey, Beans, Tortillas', N'Brown meat and season')
INSERT [dbo].[Recipes] ([Id], [Name], [Ingredients], [Instructions]) VALUES (77, N'Broccoli and Penne Chicken', N'Chicken, Broccoli, Penne Pasta, Mayo', N'Cook it up')
SET IDENTITY_INSERT [dbo].[Recipes] OFF
ALTER TABLE [dbo].[MealRecipes]  WITH CHECK ADD  CONSTRAINT [FK_MealRecipes_Meals] FOREIGN KEY([MealId])
REFERENCES [dbo].[Meals] ([Id])
GO
ALTER TABLE [dbo].[MealRecipes] CHECK CONSTRAINT [FK_MealRecipes_Meals]
GO
ALTER TABLE [dbo].[MealRecipes]  WITH CHECK ADD  CONSTRAINT [FK_MealRecipes_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([Id])
GO
ALTER TABLE [dbo].[MealRecipes] CHECK CONSTRAINT [FK_MealRecipes_Recipes]
GO
ALTER TABLE [dbo].[Meals]  WITH CHECK ADD  CONSTRAINT [FK_Meals_MealTypes] FOREIGN KEY([MealTypeId])
REFERENCES [dbo].[MealTypes] ([Id])
GO
ALTER TABLE [dbo].[Meals] CHECK CONSTRAINT [FK_Meals_MealTypes]
GO
USE [master]
GO
ALTER DATABASE [MealPlanner] SET  READ_WRITE 
GO
