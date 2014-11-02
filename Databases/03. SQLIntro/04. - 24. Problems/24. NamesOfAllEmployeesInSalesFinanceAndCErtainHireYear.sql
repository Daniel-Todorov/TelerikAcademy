--Write a SQL query to find the names of all 
--employees from the departments "Sales" and 
--"Finance" whose hire year is between 1995 and 2005.
USE [TelerikAcademy]
GO

SELECT e.[FirstName] + ' ' + e.[LastName]--, e.HireDate, d.Name
FROM [Employees] e
INNER JOIN [Departments] d
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE  d.[Name] IN ('Sales', 'Finance')
	AND e.[HireDate] BETWEEN '1995-01-01' AND '2005-01-01'