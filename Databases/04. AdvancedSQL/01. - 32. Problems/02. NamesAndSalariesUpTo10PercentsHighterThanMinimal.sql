--Write a SQL query to find the names and salaries of 
--the employees that have a salary that is up to 10% 
--higher than the minimal salary for the company. 

USE [TelerikAcademy]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Name of Employee],
	[Salary]
FROM [Employees]
WHERE [Salary] <= 
	(SELECT (MIN([Salary]) * 110) / 100 FROM [Employees])