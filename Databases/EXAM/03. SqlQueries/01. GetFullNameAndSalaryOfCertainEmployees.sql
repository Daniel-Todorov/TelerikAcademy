--1. Get the full name (first name + “ “ + last name)  of every employee 
--and its salary, for each employee with salary between $100 000 and $150 000, inclusive. 
--Sort the results by salary in ascending order.

USE [Company]
GO

SELECT [FirstName] + ' ' + [LastName] AS [Full Name],
	[YearSalary] as [Salary]
FROM [Employees]
WHERE [YearSalary] >= 100000 AND [YearSalary] <= 150000
ORDER BY [YearSalary] ASC