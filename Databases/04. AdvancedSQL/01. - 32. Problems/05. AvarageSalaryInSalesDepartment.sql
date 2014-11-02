--Write a SQL query to find the average salary in the 
--"Sales" department. 

USE [TelerikAcademy]
GO

SELECT AVG(e.[Salary]) AS [Avarage Salary in "Sales" department]
FROM [Employees] e
INNER JOIN [Departments] d
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE d.[Name] = 'Sales'