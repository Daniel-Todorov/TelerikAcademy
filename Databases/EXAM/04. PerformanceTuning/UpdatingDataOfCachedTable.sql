--Create a “cache” table for the third query from problem 3 and save all the results there for future querying. 
--Provide the .sql file, containing the stored procedures which creates the table and inserts the data. 
--You should write two stored procedures – one for creating the table and one for updating the data.

--NOTE!!! Please, take in mind my solution of problem 3 may not be correct.

USE [Company]
GO

CREATE PROCEDURE dbo.ups_FillingCachedTableForBetterPeformance
AS
BEGIN TRANSACTION 
	DELETE FROM CachedTableForBetterPeformance
	INSERT INTO CachedTableForBetterPeformance
		SELECT e.[FirstName] + ' ' + e.[LastName] AS [Full Name of Employee],
			p.[Name] AS [Project Name],
			d.[Name] AS [Department Name],
			ep.[StartingDate] AS [Project Start Date],
			ep.[EndingDate] AS [Project End Date]
		FROM [EmployeesProjects] ep
		INNER JOIN [Employees] e
			ON ep.[EmployeeId] = e.[EmployeeId]
		INNER JOIN [Projects] p
			ON ep.[ProjectId] = p.[ProjectId]
		INNER JOIN [Departments] d
			ON e.[DepartmentId] = d.[DepartmentId]
		ORDER BY e.[EmployeeId], p.[ProjectId]
COMMIT
GO