--Create a “cache” table for the third query from problem 3 and save all the results there for future querying. 
--Provide the .sql file, containing the stored procedures which creates the table and inserts the data. 
--You should write two stored procedures – one for creating the table and one for updating the data.

--NOTE!!! Please, take in mind my solution of problem 3 may not be correct.

USE [Company]
GO

CREATE PROCEDURE dbo.ups_CachedTableForBetterPeformance
AS
CREATE TABLE CachedTableForBetterPeformance(
	[Full Name of Employee] nvarchar(50),
	[Project Name] nvarchar(50),
	[Department Name] nvarchar(50),
	[Project Start Date] datetime,
	[Project End Date] datetime
)
GO