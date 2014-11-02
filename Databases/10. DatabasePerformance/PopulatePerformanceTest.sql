--Note that it takes ages for 1 mil. records, and 10 times more for 10 mil records.

USE [PerformanceTesting]
GO

DECLARE @counter int
SET @counter = 1;
WHILE(@counter < 100000)
BEGIN
  DECLARE @Date datetime
	SET @Date = 
	DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
	INSERT INTO Logs (LogDate, MsgText)
	VALUES(@Date, 'log number' + CONVERT(varchar, @counter))
	SET @counter = @counter + 1;
END
GO


CHECKPOINT; 
DBCC DROPCLEANBUFFERS;