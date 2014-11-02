--Write a SQL query to find the names of all 
--employees whose first name starts with "SA".

USE [TelerikAcademy]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Names]
FROM [Employees]
WHERE [FirstName] LIKE ('SA%')