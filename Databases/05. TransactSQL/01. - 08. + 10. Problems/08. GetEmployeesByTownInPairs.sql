--Using database cursor write a T-SQL script that 
--scans all employees and their addresses and prints 
--all pairs of employees that live in the same town.

USE [TelerikAcademy]
GO

SELECT e.[EmployeeID],
	e.[FirstName] + ISNULL(' '+ e.[MiddleName], '') + ' ' + e.[LastName] AS [EmployeeName], 
	t.[TownID], 
	t.[Name] as [TownName]
	INTO #TempEmployeesWithTowns
	FROM Employees e 
		INNER JOIN [Addresses] a 
			ON e.[AddressID] = a.[AddressID]
		INNER JOIN [Towns] t 
			ON a.[TownID] = t.[TownID]
CREATE UNIQUE CLUSTERED INDEX [Idx_TemEmp]
	ON #TempEmployeesWithTowns([EmployeeID])

DECLARE [cursor] CURSOR READ_ONLY FOR
SELECT [EmployeeID], 
		[EmployeeName], 
		[TownID],
		[TownName]
	FROM #TempEmployeesWithTowns

OPEN [cursor]
DECLARE @employeeID int, 
	@employeeName varchar(150), 
	@townID int,  
	@townName varchar(50)
FETCH NEXT FROM [cursor] 
	INTO @employeeID, @employeeName, @townID, @townName

CREATE TABLE #TempEmployeeFromSameTownPairs 
	([FirstEmployeeName] varchar(150), [SecondEmployeeName] varchar(150), [TownName] varchar(50))
WHILE @@FETCH_STATUS = 0
  BEGIN
	INSERT INTO #TempEmployeeFromSameTownPairs ([FirstEmployeeName], [SecondEmployeeName], [TownName])
		SELECT @employeeName, EmployeeName, @townName FROM #TempEmployeesWithTowns e
			WHERE e.TownID = @townID AND e.EmployeeID <> @employeeID
    FETCH NEXT FROM [cursor] 
		INTO @employeeID, @employeeName, @townID, @townName           
  END
CLOSE [cursor]
DEALLOCATE [cursor]

SELECT [TownName], 
		[FirstEmployeeName], 
		[SecondEmployeeName] 
	FROM #TempEmployeeFromSameTownPairs
	ORDER BY [TownName], [FirstEmployeeName], [SecondEmployeeName]
DROP TABLE #TempEmployeeFromSameTownPairs
DROP TABLE #TempEmployeesWithTowns
GO

--NOTE!!! Ttally not optimized...