--Write a SQL query to find the count of all employees 
--in each department and for each town. 

USE [TelerikAcademy]
GO

SELECT COUNT(e.EmployeeID) AS [Count of All Employees],
	d.Name,
	t.Name
FROM [Employees] e
INNER JOIN [Departments] d
	ON e.[DepartmentID] = d.[DepartmentID]
INNER JOIN [Addresses] a
	ON e.[AddressID] = a.[AddressID]
INNER JOIN [Towns] t
	ON a.[TownID] = t.[TownID]
GROUP BY d.[Name], t.[Name]
