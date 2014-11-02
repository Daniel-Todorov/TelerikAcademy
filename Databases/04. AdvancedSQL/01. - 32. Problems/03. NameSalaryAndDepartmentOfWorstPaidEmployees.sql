--Write a SQL query to find the full name, salary and 
--department of the employees that take the minimal 
--salary in their department. Use a nested SELECT
--statement. 

USE [TelerikAcademy]
GO

SELECT e.[FirstName] + ' ' + e.[LastName] AS [Name of Employee],
	e.[Salary],
	d.[Name] AS [Department Name]
FROM [Employees] e
LEFT OUTER JOIN [Departments] d
	ON e.DepartmentID = d.DepartmentID
WHERE e.[Salary] = 
	(SELECT MIN([Salary]) FROM [Employees])
