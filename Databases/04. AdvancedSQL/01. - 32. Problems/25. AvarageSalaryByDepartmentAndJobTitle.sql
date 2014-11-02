--Write a SQL query to display the average employee 
--salary by department and job title. 

USE [TelerikAcademy]
GO

SELECT d.[Name] AS [Department], 
		e.[JobTitle],
		AVG(e.[Salary]) AS [Avarage Salary]
	FROM [Employees] e
	INNER JOIN [Departments] d
		ON e.[DepartmentID] = d.[DepartmentID]
	GROUP BY d.[Name], e.[JobTitle]