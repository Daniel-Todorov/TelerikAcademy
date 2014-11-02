--Write a SQL query to display the number of 
--managers from each town. 

USE [TelerikAcademy]
GO

SELECT x.[Name] AS [Town Name],
	COUNT(x.[EmployeeID]) AS [Number of Managers]
FROM (SELECT t.Name,
		m.[EmployeeID]
	FROM [Employees] e
	INNER JOIN [Employees] m
		ON e.[ManagerID] = m.[EmployeeID]
	INNER JOIN [Addresses] a
		ON m.[AddressID] = a.[AddressID]
	INNER JOIN [Towns] t
		ON a.[TownID] = t.[TownID]
	GROUP BY m.[EmployeeID], t.[Name]) x
GROUP BY x.[Name]
ORDER BY [Number of Managers] DESC

--Dear, God,
--Why didn't you answered my prayer???