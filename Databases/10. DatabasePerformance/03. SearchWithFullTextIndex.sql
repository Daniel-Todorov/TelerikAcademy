--03. Add a full text index for the text column. Try to 
--search with and without the full-text index and
--compare the speed.

USE [PerformanceTesting]
GO

--Try without indexing
SELECT [MsgText] FROM [Logs]
WHERE [MsgText] LIKE '%50%'

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;

ALTER TABLE Logs
ADD CONSTRAINT UK_Logs_MsgText UNIQUE (MsgText)

CREATE FULLTEXT CATALOG [LogsFullText]
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON [Logs]([MsgText])
KEY INDEX [UK_Logs_LogId]
ON [LogsFullText]
WITH CHANGE_TRACKING AUTO

--Try with  full text index
SELECT [MsgText] FROM [Logs]
WHERE CONTAINS([MsgText],'50')