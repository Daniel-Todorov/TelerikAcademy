--Write a SQL query to find all the employees and the 
--manager for each of them along with the employees 
--that do not have manager. Use right outer join. 
--Rewrite the query to use left outer join.
USE [TelerikAcademy]
GO

SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employee Name],
m.[FirstName] + ' ' + m.[LastName] AS [Manager Name]
FROM [Employees] m
RIGHT OUTER JOIN [Employees] e
	ON e.ManagerID = m.EmployeeID--SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employee Name],
--m.[FirstName] + ' ' + m.[LastName] AS [Manager Name]
--FROM [Employees] e
--LEFT OUTER JOIN [Employees] m
--	ON e.ManagerID = m.EmployeeID