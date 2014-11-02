--Write a SQL query to find the number of all 
--employees that have manager. 

USE [TelerikAcademy]
GO

SELECT COUNT(*) AS [Number of Employees with Manager]
FROM [Employees]
WHERE [ManagerID] IS NOT NULL