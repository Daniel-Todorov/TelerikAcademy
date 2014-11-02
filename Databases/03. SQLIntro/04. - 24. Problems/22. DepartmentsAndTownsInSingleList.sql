--Write a SQL query to find all departments and all 
--town names as a single list. Use UNION.

USE [TelerikAcademy]
GO

SELECT [Name] AS [Departments and Towns]
FROM [Departments]
UNION
SELECT [Name]
FROM [Towns]