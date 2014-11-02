--Write a SQL query to find the number of employees 
--in the "Sales" department. 

USE [TelerikAcademy]
GO

SELECT COUNT(*) AS [Number of employees in "Sales" Department]
FROM [Employees] e
INNER JOIN [Departments] d
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE d.[Name] = 'Sales'