--Write a SQL query to find all employees along with 
--their address. Use inner join with ON clause.

USE [TelerikAcademy]
GO

SELECT *
FROM [Employees] e
INNER JOIN [Addresses] a
	ON e.AddressID = a.AddressID