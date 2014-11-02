--Write a SQL to find the full name of each employee.

USE [TelerikAcademy]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Full Name] 
FROM [Employees]