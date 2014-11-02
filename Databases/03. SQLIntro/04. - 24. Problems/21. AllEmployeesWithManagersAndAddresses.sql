--Write a SQL query to find all employees, along with 
--their manager and their address. Join the 3 tables: 
--Employees e, Employees m and Addresses a.

USE [TelerikAcademy]
GO

SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employee Name], 
	m.[FirstName] + ' ' + m.[LastName] AS [Manager Name],
	a.AddressText AS [Employee Adress]
FROM [Employees] e
LEFT OUTER JOIN [Employees] m
	ON e.ManagerID = m.EmployeeID
INNER JOIN [Addresses] a
	ON e.AddressID = a.AddressID