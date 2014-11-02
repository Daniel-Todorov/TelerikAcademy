--Find how to use temporary tables in SQL Server. 
--Using temporary tables backup all records from 
--EmployeesProjects and restore them back after 
--dropping and re-creating the table. 

USE [TelerikAcademy]
GO

BEGIN TRANSACTION
--We copy the info to the temporary table
	SELECT *
		INTO #TemporaryEmployeeProjectTable
		FROM [EmployeesProjects]
--We drop the original table
	DROP TABLE [EmployeesProjects]
--We copy the info from the temporary table to a new table with the name fo the original
	SELECT *
		INTO [EmployeeProject]
		FROM #TemporaryEmployeeProjectTable
--commit and prey we haven't screwed up the information int he table
COMMIT TRANSACTION

--IT WORKED :O :O :O