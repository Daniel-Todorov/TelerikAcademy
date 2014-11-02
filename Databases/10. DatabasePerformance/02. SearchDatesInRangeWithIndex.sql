--02. Add an index to speed-up the search by date. Test
--the search speed (after cleaning the cache).

--NOTE!!! To be honest I tsted this with only about 500 000 records.
--There was basically no difference between index and no-index search speed of dates in range.

USE [PerformanceTesting]
GO

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;

CREATE INDEX IDX_Logs_LogDate ON [Logs]([LogDate])

SELECT [LogDate]
	FROM [Logs]
	WHERE [LogDate] 
		BETWEEN CONVERT(datetime, '1990-01-01') 
		AND CONVERT(datetime, '2000-01-01')

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;