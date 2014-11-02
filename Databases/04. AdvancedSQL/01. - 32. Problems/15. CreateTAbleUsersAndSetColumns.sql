--Write a SQL statement to create a table Users. 
--Users should have username, password, full name 
--and last login time. Choose appropriate data types 
--for the table fields. Define a primary key column 
--with a primary key constraint. Define the primary 
--key column as identity to facilitate inserting records. 
--Define unique constraint to avoid repeating 
--usernames. Define a check constraint to ensure the 
--password is at least 5 characters long.

USE [TelerikAcademy]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
	DROP TABLE [dbo].[Users]
GO

CREATE TABLE [Users] (
	UserID int IDENTITY PRIMARY KEY,
	UserName nvarchar(50) UNIQUE NOT NULL,
	UserPassword nvarchar(50)
		CHECK (LEN(UserPassword) >= 5),
	UserFullName nvarchar(100) NOT NULL,
	LastLoginTime datetime
		CONSTRAINT DF_LastLoginTime DEFAULT GETDATE(),
)