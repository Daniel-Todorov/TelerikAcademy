--Write a SQL query to display the town where 
--maximal number of employees work. 

USE [TelerikAcademy]
GO

SELECT x.[Town Name] AS [Town with Maximal Number of Employees]
FROM (SELECT TOP 1 t.[Name] AS [Town Name],
		COUNT(e.EmployeeID) AS [Number of Employees]
	FROM [Employees] e
	INNER JOIN [Addresses] a
		ON e.[AddressID] = a.[AddressID]
	INNER JOIN [Towns] t
		ON a.[TownID] = t.[TownID]
	GROUP BY t.Name
	ORDER BY [Number of Employees] DESC) x