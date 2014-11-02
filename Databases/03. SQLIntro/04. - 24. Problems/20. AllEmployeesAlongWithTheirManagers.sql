--Write a SQL query to find all employees along with 
--their manager.

USE [TelerikAcademy]
GO

SELECT *
FROM [Employees] e
LEFT OUTER JOIN [Employees] m
ON e.ManagerID = m.EmployeeID

--NOTE!
--The problem doesn't say if only the employees with manages should be displayed.
--That's why I use LEFT OUTER JOIN.