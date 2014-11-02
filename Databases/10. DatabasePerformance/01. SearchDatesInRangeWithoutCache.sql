--01. Create a table in SQL Server with 10 000 000 log
--entries (date + text). Search in the table by date 
--range. Check the speed (without chaching).

USE [PerformanceTesting]
GO

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;

SELECT [LogDate] 
	FROM [Logs] 
	WHERE [LogDate] 
		BETWEEN CONVERT(datetime, '1990-01-01') 
		AND CONVERT(datetime, '2000-01-01')

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;