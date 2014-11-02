--Write a SQL query to display the minimal employee 
--salary by department and job title along with the 
--name of some of the employees that take it. 

USE [TelerikAcademy]
GO

SELECT x.[Department],
	x.[JobTitle], 
	x.[Minimal Salary],
	e.[FirstName] + ' ' + e.[LastName] 
FROM [Employees] e 
INNER JOIN (SELECT d.[Name] AS [Department],
				e.[JobTitle],
				MIN(e.[Salary]) AS [Minimal Salary]
			FROM [Employees] e
			INNER JOIN [Departments] d
				ON e.[DepartmentID] = d.[DepartmentID]
			GROUP BY d.[Name], e.[JobTitle]) x
	ON e.[JobTitle] = x.[JobTitle] AND e.[Salary] = x.[Minimal Salary]
ORDER BY e.JobTitle

--Dear, God
--I beg you, keep the evil of SQL away
--and don't let me ever again write a query like this!
--Amen!