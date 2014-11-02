--3. Get each employee’s full name (first name + “ “ + last name), 
--project’s name, department’s name, starting and ending date for each employee in project. 
--Additionally get the number of all reports, which time of reporting is between the start and end date. 
--Sort the results first by the employee id, then by the project id. 

--(This query is slow, be patient!)

USE [Company]
GO

SELECT e.[FirstName] + ' ' + e.[LastName] AS [Full Name of Employee],
	p.[Name] AS [Project Name],
	d.[Name] AS [Department Name],
	ep.[StartingDate] AS [Project Start Date],
	ep.[EndingDate] AS [Project End Date]
FROM [EmployeesProjects] ep
INNER JOIN [Employees] e
	ON ep.[EmployeeId] = e.[EmployeeId]
INNER JOIN [Projects] p
	ON ep.[ProjectId] = p.[ProjectId]
INNER JOIN [Departments] d
	ON e.[DepartmentId] = d.[DepartmentId]
ORDER BY e.[EmployeeId], p.[ProjectId]