--Write a SQL query to find all employees that do not 
--have manager.

USE [TelerikAcademy]
GO

SELECT *
FROM [Employees]
WHERE [ManagerID] IS NULL