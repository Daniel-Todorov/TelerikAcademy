--Write a SQL query to find the names of all 
--employees whose last name is exactly 5 characters 
--long. Use the built-in LEN(str) function. 

USE [TelerikAcademy]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Name of Employee]
FROM [Employees]
WHERE LEN([LastName]) = 5