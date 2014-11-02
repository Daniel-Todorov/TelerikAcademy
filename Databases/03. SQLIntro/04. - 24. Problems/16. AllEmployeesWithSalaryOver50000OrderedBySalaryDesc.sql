--Write a SQL query to find all employees that have 
--salary more than 50000. Order them in decreasing 
--order by salary.

USE [TelerikAcademy]
GO

SELECT *
FROM [Employees]
WHERE [Salary] > 50000
ORDER BY [Salary]
DESC