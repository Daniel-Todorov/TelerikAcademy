--Write a SQL query to find the average salary in the 
--department #1. 

USE [TelerikAcademy]
GO

SELECT AVG([Salary]) AS [Avarage Salary in Department #1]
FROM [Employees]
WHERE [DepartmentID] = 1