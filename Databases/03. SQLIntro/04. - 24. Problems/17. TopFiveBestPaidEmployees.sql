--Write a SQL query to find the top 5 best paid 
--employees.

USE [TelerikAcademy]
GO

SELECT TOP 5 *
FROM [Employees]
ORDER BY [Salary]
DESC