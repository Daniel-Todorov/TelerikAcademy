--Write a SQL query to find all departments and the 
--average salary for each of them. 

USE [TelerikAcademy]
GO

SELECT d.[Name] AS [Department],
	AVG(e.[Salary]) AS [Avarage Salary]
FROM [Departments] d
INNER JOIN [Employees] e
	ON d.[DepartmentID] = e.[DepartmentID]
GROUP BY d.[Name]