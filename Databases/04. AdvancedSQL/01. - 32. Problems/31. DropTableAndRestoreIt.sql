--Start a database transaction and drop the table 
--EmployeesProjects. Now how you could restore 
--back the lost table data? 

USE [TelerikAcademy]
GO

--Snapshotting
CREATE DATABASE Snapshottest ON(Name ='TelerikAcademy',
		FileName='D:\MSSQL12.MSSQLSERVER\MSSQL\DATA\TelerikAcademy.ss')
	AS SNAPSHOT OF [TelerikAcademy];
GO

BEGIN TRANSACTION
--Dropping table
	DROP TABLE [EmployeesProjects]
--Restoring data
	SELECT * INTO EmployeesProjects
		FROM [Snapshottest].[dbo].[EmployeesProjects]
COMMIT TRANSACTION

