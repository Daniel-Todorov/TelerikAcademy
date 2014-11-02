--Write a SQL statement to create a table Groups. 
--Groups should have unique name (use unique 
--constraint). Define primary key and identity column.

USE [TelerikAcademy]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Groups]') AND type in (N'U'))
	DROP TABLE [dbo].[Groups]
GO

CREATE TABLE [Groups](
	[GroupID] int IDENTITY PRIMARY KEY,
	[GroupName] nvarchar(50) NOT NULL UNIQUE
)