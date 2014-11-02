--Write a SQL query to find all managers that have 
--exactly 5 employees. Display their first name and 
--last name. 

USE [TelerikAcademy]
GO

SELECT m.[FirstName] + ' ' + m.[LastName] AS [Manager],
	COUNT(e.[EmployeeID]) AS [Number of Employees Managed]
FROM [Employees] e
INNER JOIN [Employees] m
	ON e.[ManagerID] = m.[EmployeeID]
GROUP BY e.[ManagerID], m.[FirstName] + ' ' + m.[LastName]
HAVING COUNT(e.[EmployeeID]) = 5