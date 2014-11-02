--Write a SQL query to find the names of all 
--employees whose last name contains "ei".

USE [TelerikAcademy]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Names]
FROM [Employees]
WHERE [LastName] LIKE ('%ei%')