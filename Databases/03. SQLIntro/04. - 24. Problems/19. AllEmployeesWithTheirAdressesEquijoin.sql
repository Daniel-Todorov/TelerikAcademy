--Write a SQL query to find all employees and their 
--address. Use equijoins (conditions in the WHERE
--clause).

USE [TelerikAcademy]
GO

SELECT *
FROM [Employees] e, [Addresses] a
WHERE e.AddressID = a.AddressID