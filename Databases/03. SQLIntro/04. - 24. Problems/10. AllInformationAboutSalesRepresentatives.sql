--Write a SQL query to find all information about the 
--employees whose job title is “Sales Representative“.

USE [TelerikAcademy]
GO

SELECT * 
FROM [Employees]
WHERE [JobTitle] = 'Sales Representative'