--Write SQL statements to insert in the Users table 
--the names of all employees from the Employees
--table. Combine the first and last names as a full 
--name. For username use the first letter of the first 
--name + the last name (in lowercase). Use the same 
--for the password, and NULL for last login time. 

USE [TelerikAcademy]
GO


INSERT INTO [Users] ([UserName], [UserPassword], [UserFullName], [LastLoginTime])
	SELECT SUBSTRING([FirstName], 1, 1) + LOWER([LastName]) + CONVERT(nvarchar, [EmployeeID]),
			SUBSTRING([FirstName], 1, 1) + LOWER([LastName]),
			[FirstName] + ' ' + [LastName],
			NULL
		FROM [Employees]
		WHERE LEN([LastName]) >= 4

--NOTE!!! The check constraint I had to implement earlier gives and error
--so I add a WHERE clause to get only the last names which are at least 4 characters long.
--NOTE!!! Next problem - apparently there is a duplicate username and we have a unique constraint about that already
--so I add the ID of the employee to the username