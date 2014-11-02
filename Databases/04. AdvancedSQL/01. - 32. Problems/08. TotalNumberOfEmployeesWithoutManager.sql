--Write a SQL query to find the number of all 
--employees that have no manager. 

USE [TelerikAcademy]
GO

SELECT COUNT(*) AS [Number of Employees without Manager]
FROM [Employees]
WHERE [ManagerID] IS NULL