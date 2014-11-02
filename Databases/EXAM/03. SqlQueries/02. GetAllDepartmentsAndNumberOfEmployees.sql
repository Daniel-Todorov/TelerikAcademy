--2. Get all departments and how many employees there are in each one. 
--Sort the result by the number of employees in descending order.

USE [Company]
GO

SELECT d.[Name] AS [Department Name],
COUNT(e.[EmployeeId]) AS [Number of Employees in the Department]
FROM [Departments] d
INNER JOIN [Employees] e
	ON e.[DepartmentId] = d.[DepartmentId]
GROUP BY d.[Name]
ORDER BY COUNT(e.[EmployeeId]) DESC